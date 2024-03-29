//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Light.GlobalLightComponent lightGlobalLight { get { return (Light.GlobalLightComponent)GetComponent(GameComponentsLookup.LightGlobalLight); } }
    public bool hasLightGlobalLight { get { return HasComponent(GameComponentsLookup.LightGlobalLight); } }

    public void AddLightGlobalLight(bool newEnabled, int[] newLayers, int newLightOrder, System.Numerics.Vector3 newColor, float newIntensity, float newMerge) {
        var index = GameComponentsLookup.LightGlobalLight;
        var component = (Light.GlobalLightComponent)CreateComponent(index, typeof(Light.GlobalLightComponent));
        component.Enabled = newEnabled;
        component.Layers = newLayers;
        component.LightOrder = newLightOrder;
        component.Color = newColor;
        component.Intensity = newIntensity;
        component.Merge = newMerge;
        AddComponent(index, component);
    }

    public void ReplaceLightGlobalLight(bool newEnabled, int[] newLayers, int newLightOrder, System.Numerics.Vector3 newColor, float newIntensity, float newMerge) {
        var index = GameComponentsLookup.LightGlobalLight;
        var component = (Light.GlobalLightComponent)CreateComponent(index, typeof(Light.GlobalLightComponent));
        component.Enabled = newEnabled;
        component.Layers = newLayers;
        component.LightOrder = newLightOrder;
        component.Color = newColor;
        component.Intensity = newIntensity;
        component.Merge = newMerge;
        ReplaceComponent(index, component);
    }

    public void RemoveLightGlobalLight() {
        RemoveComponent(GameComponentsLookup.LightGlobalLight);
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

    static Entitas.IMatcher<GameEntity> _matcherLightGlobalLight;

    public static Entitas.IMatcher<GameEntity> LightGlobalLight {
        get {
            if (_matcherLightGlobalLight == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LightGlobalLight);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLightGlobalLight = matcher;
            }

            return _matcherLightGlobalLight;
        }
    }
}
