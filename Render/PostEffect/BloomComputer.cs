﻿using Entitas;
using PixelForge;
using pp;

namespace Render.PostEffect;

public class BloomComputer : PostProcessComputer {
	GaussianBlurComputer _gaussianBlurComputer;
	RenderFullscreen _bloom_extract_bright;
	RenderFullscreen _bloom_add_to_screen;
	RenderTexture tempRT1;
	RenderTexture tempRT2;

	public BloomComputer() {
		_gaussianBlurComputer = new GaussianBlurComputer();
		_bloom_extract_bright = new RenderFullscreen( "Blit.vert", "PPBloomExtractBright.frag" );
		_bloom_add_to_screen = new RenderFullscreen( "Blit.vert", "PPBloomAddToScreen.frag" );
	}

	public override void Render( RenderTexture rt ) {
		Blitter.Blit( rt, tempRT1, _bloom_extract_bright );
		_gaussianBlurComputer.Render( tempRT1 );
		_bloom_add_to_screen.SetTexture( "_ScreenCol", rt );
		Blitter.Blit( tempRT1, tempRT2, _bloom_add_to_screen );
		Blitter.Blit( tempRT2, rt );
	}

	public override void SetParams( IComponent param ) {
		if( param is BloomComponent b ) {
			tempRT1 = TexturePool.GetRT( GameSetting.WindowWidth, GameSetting.WindowHeight );
			tempRT2 = TexturePool.GetRT( GameSetting.WindowWidth, GameSetting.WindowHeight );
			var gaussianParam = new GaussianBlurComponent();
			gaussianParam.Iterations = b.BlurIterations;
			gaussianParam.Offset = b.BlurOffset;
			_gaussianBlurComputer.SetParams( gaussianParam );
			var bloomThreshold = b.BloomThreshold;
			var bloomIntensity = b.BloomIntensity;
			_bloom_extract_bright.SetUniform( "bloomThreshold", bloomThreshold );
			_bloom_extract_bright.SetUniform( "bloomIntensity", bloomIntensity );
			TexturePool.ReturnRT( tempRT1 );
			TexturePool.ReturnRT( tempRT2 );
		}
	}

	public override void Dispose() {
		TexturePool.ReturnRT( tempRT1 );
		_gaussianBlurComputer.Dispose();
	}

	~BloomComputer() {
		Dispose();
	}
}