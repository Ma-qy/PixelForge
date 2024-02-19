﻿using Entitas;
using Entitas.CodeGeneration.Attributes;
using Render.PostEffect;

namespace pp;

[Game]
public class BloomComponnet : IComponent, IPostProcessingComponent {
	public bool Enabled { get; set; }
	public int[] Layers { get; set; }
	public float Intensity;
	public BloomComputer Computer;
}