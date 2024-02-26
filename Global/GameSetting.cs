﻿namespace PixelForge;

public static class GameSetting {
	public const int WindowWidth = 1920;
	public const int WindowHeight = 1080;
	public const string Name = "PixelForge";

	// light setting
	public const int LightQuality =0;//best:0,good:1,low:2
	public const int LightBlurIterations = 1;
	public const int LightBlurOffset = 3;
	public const int LightAngularPrecision = 360;
	public const int LightRadiusPrecision = 200;
	
	
	
	public static string ProjectPath
	{
		get
		{
			PlatformID platform = Environment.OSVersion.Platform;
			if (platform == PlatformID.Win32NT || platform == PlatformID.Win32S || platform == PlatformID.Win32Windows || platform == PlatformID.WinCE)
			{
				return @"../../../";
			}
			else
			{
				return @"./";
			}
		}
	}
	public const int MaxInstancePerDrawCall = 50;
	public const int MaxRenderLayer = 3;



	
	/// <summary>
	/// 每帧获取deltaTime,毫秒
	/// </summary>
	public static int DeltaTime {
		get;
		private set;
	}=10;

	public static void Load() {
		//加载资源
		DeltaTime = 10;
	}

	public static void Update( double deltaTime ) {
		DeltaTime = (int)( deltaTime * 1000 );
	}
}