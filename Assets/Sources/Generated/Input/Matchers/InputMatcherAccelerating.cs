//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class InputMatcher {

    static IMatcher<InputEntity> _matcherAccelerating;

    public static IMatcher<InputEntity> Accelerating {
        get {
            if(_matcherAccelerating == null) {
                var matcher = (Matcher<InputEntity>)Matcher<InputEntity>.AllOf(InputComponentsLookup.Accelerating);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherAccelerating = matcher;
            }

            return _matcherAccelerating;
        }
    }
}
