//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BonusTimer bonusTimer { get { return (BonusTimer)GetComponent(GameComponentsLookup.BonusTimer); } }
    public bool hasBonusTimer { get { return HasComponent(GameComponentsLookup.BonusTimer); } }

    public void AddBonusTimer(float newTick, Sources.BonusType newBonusType) {
        var index = GameComponentsLookup.BonusTimer;
        var component = (BonusTimer)CreateComponent(index, typeof(BonusTimer));
        component.Tick = newTick;
        component.BonusType = newBonusType;
        AddComponent(index, component);
    }

    public void ReplaceBonusTimer(float newTick, Sources.BonusType newBonusType) {
        var index = GameComponentsLookup.BonusTimer;
        var component = (BonusTimer)CreateComponent(index, typeof(BonusTimer));
        component.Tick = newTick;
        component.BonusType = newBonusType;
        ReplaceComponent(index, component);
    }

    public void RemoveBonusTimer() {
        RemoveComponent(GameComponentsLookup.BonusTimer);
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

    static Entitas.IMatcher<GameEntity> _matcherBonusTimer;

    public static Entitas.IMatcher<GameEntity> BonusTimer {
        get {
            if (_matcherBonusTimer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BonusTimer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBonusTimer = matcher;
            }

            return _matcherBonusTimer;
        }
    }
}