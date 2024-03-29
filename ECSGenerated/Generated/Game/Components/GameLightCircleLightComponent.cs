//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Light.CircleLightComponent lightCircleLight { get { return (Light.CircleLightComponent)GetComponent(GameComponentsLookup.LightCircleLight); } }
    public bool hasLightCircleLight { get { return HasComponent(GameComponentsLookup.LightCircleLight); } }

    public void AddLightCircleLight(bool newEnabled, int[] newLayers, int newLightOrder, float newRadius, float newIntensity, float newVolume, System.Numerics.Vector3 newColor, float newRadialFallOff, float newAngle) {
        var index = GameComponentsLookup.LightCircleLight;
        var component = (Light.CircleLightComponent)CreateComponent(index, typeof(Light.CircleLightComponent));
        component.Enabled = newEnabled;
        component.Layers = newLayers;
        component.LightOrder = newLightOrder;
        component.Radius = newRadius;
        component.Intensity = newIntensity;
        component.Volume = newVolume;
        component.Color = newColor;
        component.RadialFallOff = newRadialFallOff;
        component.Angle = newAngle;
        AddComponent(index, component);
    }

    public void ReplaceLightCircleLight(bool newEnabled, int[] newLayers, int newLightOrder, float newRadius, float newIntensity, float newVolume, System.Numerics.Vector3 newColor, float newRadialFallOff, float newAngle) {
        var index = GameComponentsLookup.LightCircleLight;
        var component = (Light.CircleLightComponent)CreateComponent(index, typeof(Light.CircleLightComponent));
        component.Enabled = newEnabled;
        component.Layers = newLayers;
        component.LightOrder = newLightOrder;
        component.Radius = newRadius;
        component.Intensity = newIntensity;
        component.Volume = newVolume;
        component.Color = newColor;
        component.RadialFallOff = newRadialFallOff;
        component.Angle = newAngle;
        ReplaceComponent(index, component);
    }

    public void RemoveLightCircleLight() {
        RemoveComponent(GameComponentsLookup.LightCircleLight);
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

    static Entitas.IMatcher<GameEntity> _matcherLightCircleLight;

    public static Entitas.IMatcher<GameEntity> LightCircleLight {
        get {
            if (_matcherLightCircleLight == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LightCircleLight);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLightCircleLight = matcher;
            }

            return _matcherLightCircleLight;
        }
    }
}
