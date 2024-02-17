﻿using Entitas;
using Render;
using System.Numerics;

namespace PixelForge;

public class HierarchySystem : IInitializeSystem {
	readonly Contexts _contexts;

	public HierarchySystem( Contexts contexts ) {
		_contexts = contexts;
	}

	public void Initialize() {
		InitEntity();
	}

	void InitEntity() {
		var camera = _contexts.game.CreateEntity();
		camera.AddComponentName( "mainCamera" );
		camera.AddComponentPosition( 0, 0, 0 );
		camera.AddComponentCamera( 0, true, 0.5f );
		camera.AddComponentBasicMove( true, 0.0005f );
		//
		// var globalLight = _contexts.game.CreateEntity();
		//
		// var quad1 = _contexts.game.CreateEntity();
		// quad1.AddComponentName( "quad1" );
		// quad1.AddComponentPosition( 0, 0, 0 );
		// quad1.AddComponentSize( 0.2f, 0.2f );
		// quad1.AddComponentRotation( 0 );
		// quad1.AddMatRenderSingleTrigger( true, 0 );
		//
		// //
		// var quad2 = _contexts.game.CreateEntity();
		// quad2.AddComponentName( "quad2" );
		// quad2.AddComponentPosition( 1, 0, 0 );
		// quad2.AddComponentSize( 0.2f, 0.2f );
		// quad2.AddComponentRotation( 0 );
		// quad2.AddMatRenderSingleTrigger( true, 1 );
		//

		var quad3 = _contexts.game.CreateEntity();
		quad3.AddComponentName( "quad3" );
		quad3.AddComponentPosition( 0, 1, 0 );
		quad3.AddComponentSize( 0.5f, 0.5f );
		quad3.AddComponentRotation( 0 );
		quad3.AddMatRenderSingleTrigger( true, 0 );
		quad3.isComponentCellularAutomaton = true;
	}
}