// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDeciding.cs

using Robotango.Core.System;

namespace Robotango.Core.Abilities.Desirous
{
    public interface IDeciding : IAbility
    {
        void MakeDecision( IReality reality );
    }
}