//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Component.WoodComponent componentWoodComponent = new Component.WoodComponent();

    public bool isComponentWood {
        get { return HasComponent(GameComponentsLookup.ComponentWood); }
        set {
            if (value != isComponentWood) {
                var index = GameComponentsLookup.ComponentWood;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentWoodComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherComponentWood;

    public static Entitas.IMatcher<GameEntity> ComponentWood {
        get {
            if (_matcherComponentWood == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentWood);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentWood = matcher;
            }

            return _matcherComponentWood;
        }
    }
}
