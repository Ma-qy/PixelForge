//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Component.SteamComponent componentSteamComponent = new Component.SteamComponent();

    public bool isComponentSteam {
        get { return HasComponent(GameComponentsLookup.ComponentSteam); }
        set {
            if (value != isComponentSteam) {
                var index = GameComponentsLookup.ComponentSteam;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentSteamComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherComponentSteam;

    public static Entitas.IMatcher<GameEntity> ComponentSteam {
        get {
            if (_matcherComponentSteam == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentSteam);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentSteam = matcher;
            }

            return _matcherComponentSteam;
        }
    }
}