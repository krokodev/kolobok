// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinking.cs

using System;
using Robotango.Core.Elements.Thinking;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Interfaces.Abilities
{
    public interface IThinking : IAbility
    {
        void ImplementBeliefs();
        void AddBelief( Action< IReality > realityAction );
        void AddBelief( IBelief belief );
        IReality InnerReality { get; }
        bool HasBelief( IBelief belief );
    }
}