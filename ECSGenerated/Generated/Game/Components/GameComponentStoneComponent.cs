//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Component.StoneComponent componentStoneComponent = new Component.StoneComponent();

    public bool isComponentStone {
        get { return HasComponent(GameComponentsLookup.ComponentStone); }
        set {
            if (value != isComponentStone) {
                var index = GameComponentsLookup.ComponentStone;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentStoneComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherComponentStone;

    public static Entitas.IMatcher<GameEntity> ComponentStone {
        get {
            if (_matcherComponentStone == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentStone);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentStone = matcher;
            }

            return _matcherComponentStone;
        }
    }
}
