// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinking.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Thinking;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Interfaces.Abilities
{
    public interface IThinking : IAbility, IVerifiable, IResearchable
    {
        void Think();
        void AddBelief( Action< IReality > realityAction );
        IReality Imagination { get; }
        bool HasBelief( IBelief belief );
    }
}