//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Component.CellularAutomationComponent componentCellularAutomationComponent = new Component.CellularAutomationComponent();

    public bool isComponentCellularAutomation {
        get { return HasComponent(GameComponentsLookup.ComponentCellularAutomation); }
        set {
            if (value != isComponentCellularAutomation) {
                var index = GameComponentsLookup.ComponentCellularAutomation;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentCellularAutomationComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherComponentCellularAutomation;

    public static Entitas.IMatcher<GameEntity> ComponentCellularAutomation {
        get {
            if (_matcherComponentCellularAutomation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentCellularAutomation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentCellularAutomation = matcher;
            }

            return _matcherComponentCellularAutomation;
        }
    }
}
