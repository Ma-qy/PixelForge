using System.Numerics;
using Silk.NET.OpenGL;

namespace Render {
	public class Shader : IDisposable {
		readonly private uint _handle;
		readonly private GL _gl;

		public Shader( GL gl, string vertexPath, string fragmentPath, bool isShaderString = false ) {
			_gl = gl;

			uint vertex = LoadShader( ShaderType.VertexShader, vertexPath, isShaderString );
			uint fragment = LoadShader( ShaderType.FragmentShader, fragmentPath, isShaderString );

			_handle = _gl.CreateProgram();
			_gl.AttachShader( _handle, vertex );
			_gl.AttachShader( _handle, fragment );
			_gl.LinkProgram( _handle );
			_gl.GetProgram( _handle, GLEnum.LinkStatus, out var status );
			if( status == 0 ) {
				Console.WriteLine( "着色器程序链接失败: " + _gl.GetProgramInfoLog( _handle ) + "\n" + vertexPath + "\n" + fragmentPath );
				throw new Exception( $"Program failed to link with error: {_gl.GetProgramInfoLog( _handle )}" );
			}
			_gl.DetachShader( _handle, vertex );
			_gl.DetachShader( _handle, fragment );
			_gl.DeleteShader( vertex );
			_gl.DeleteShader( fragment );
		}

		/// <summary>
		/// 先use，再set uniform
		/// </summary>
		public void Use() {
			_gl.UseProgram( _handle );
		}

		public void SetUniform( int textureNum, string texName, Texture texture ) {
			TextureUnit textureUnit = (TextureUnit)( (int)TextureUnit.Texture0 + textureNum );
			texture.Bind( textureUnit );
			int textureLocation = _gl.GetUniformLocation( _handle, texName );
			if( textureLocation == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			_gl.Uniform1( textureLocation, textureNum );
	 }

		public void SetUniform( string name, int value ) {
			int location = _gl.GetUniformLocation( _handle, name );
			if( location == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			_gl.Uniform1( location, value );
		}

		public unsafe void SetUniform( string name, Matrix4x4 value ) {
			//A new overload has been created for setting a uniform so we can use the transform in our shader.
			int location = _gl.GetUniformLocation( _handle, name );
			if( location == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			_gl.UniformMatrix4( location, 1, false, (float*)&value );
		}

		public void SetUniform( string name, Vector2 value ) {
			int location = _gl.GetUniformLocation( _handle, name );
			if( location == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			_gl.Uniform2( location, value.X, value.Y );
		}

		public void SetUniform( string name, float[] value ) {
			int location = _gl.GetUniformLocation( _handle, name );
			if( location == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			var num = value.Length;

			_gl.Uniform1( location, (uint)num, value );
		}

		public void SetUniform( string name, float value ) {
			int location = _gl.GetUniformLocation( _handle, name );
			if( location == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			_gl.Uniform1( location, value );
		}

		public void SetUniform( string name, Vector3 value ) {
			int location = _gl.GetUniformLocation( _handle, name );
			if( location == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			_gl.Uniform3( location, value.X, value.Y, value.Z );
		}
		
		public void SetUniform( string name, Vector4 value ) {
			int location = _gl.GetUniformLocation( _handle, name );
			if( location == -1 ) {
				// Console.WriteLine( $"{name} uniform not found on shader." );
				return;
			}
			_gl.Uniform4( location, value.X, value.Y, value.Z, value.W );
		}


		public void Dispose() {
			_gl.DeleteProgram( _handle );
		}

		private uint LoadShader( ShaderType type, string path, bool isShaderString = false ) {
			string src = !isShaderString ? File.ReadAllText( path ) : path;
			uint handle = _gl.CreateShader( type );
			_gl.ShaderSource( handle, src );
			_gl.CompileShader( handle );
			string infoLog = _gl.GetShaderInfoLog( handle );
			if( !string.IsNullOrWhiteSpace( infoLog ) ) {
				throw new Exception( $"Error compiling shader of type {type}, failed with error {infoLog}" );
			}

			return handle;
		}
	}
}