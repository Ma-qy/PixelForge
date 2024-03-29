//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Component.TextureComponent componentTexture { get { return (Component.TextureComponent)GetComponent(GameComponentsLookup.ComponentTexture); } }
    public bool hasComponentTexture { get { return HasComponent(GameComponentsLookup.ComponentTexture); } }

    public void AddComponentTexture(string newTextureName, Silk.NET.OpenGL.Texture? newTexture, string? newTextureFileName) {
        var index = GameComponentsLookup.ComponentTexture;
        var component = (Component.TextureComponent)CreateComponent(index, typeof(Component.TextureComponent));
        component.TextureName = newTextureName;
        component.Texture = newTexture;
        component.TextureFileName = newTextureFileName;
        AddComponent(index, component);
    }

    public void ReplaceComponentTexture(string newTextureName, Silk.NET.OpenGL.Texture? newTexture, string? newTextureFileName) {
        var index = GameComponentsLookup.ComponentTexture;
        var component = (Component.TextureComponent)CreateComponent(index, typeof(Component.TextureComponent));
        component.TextureName = newTextureName;
        component.Texture = newTexture;
        component.TextureFileName = newTextureFileName;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentTexture() {
        RemoveComponent(GameComponentsLookup.ComponentTexture);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentTexture;

    public static Entitas.IMatcher<GameEntity> ComponentTexture {
        get {
            if (_matcherComponentTexture == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentTexture);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentTexture = matcher;
            }

            return _matcherComponentTexture;
        }
    }
}
