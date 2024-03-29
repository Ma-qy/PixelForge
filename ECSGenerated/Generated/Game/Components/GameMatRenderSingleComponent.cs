//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Mat.RenderSingleComponent matRenderSingle { get { return (Mat.RenderSingleComponent)GetComponent(GameComponentsLookup.MatRenderSingle); } }
    public bool hasMatRenderSingle { get { return HasComponent(GameComponentsLookup.MatRenderSingle); } }

    public void AddMatRenderSingle(bool newIsVisible, int newLayer, Render.RenderQuad? newRenderer) {
        var index = GameComponentsLookup.MatRenderSingle;
        var component = (Mat.RenderSingleComponent)CreateComponent(index, typeof(Mat.RenderSingleComponent));
        component.IsVisible = newIsVisible;
        component.Layer = newLayer;
        component.Renderer = newRenderer;
        AddComponent(index, component);
    }

    public void ReplaceMatRenderSingle(bool newIsVisible, int newLayer, Render.RenderQuad? newRenderer) {
        var index = GameComponentsLookup.MatRenderSingle;
        var component = (Mat.RenderSingleComponent)CreateComponent(index, typeof(Mat.RenderSingleComponent));
        component.IsVisible = newIsVisible;
        component.Layer = newLayer;
        component.Renderer = newRenderer;
        ReplaceComponent(index, component);
    }

    public void RemoveMatRenderSingle() {
        RemoveComponent(GameComponentsLookup.MatRenderSingle);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMatRenderSingle;

    public static Entitas.IMatcher<GameEntity> MatRenderSingle {
        get {
            if (_matcherMatRenderSingle == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MatRenderSingle);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMatRenderSingle = matcher;
            }

            return _matcherMatRenderSingle;
        }
    }
}
