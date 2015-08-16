// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinking.cs

using System;
using Robotango.Core.Abilities.Thinking.Beliefs_XXXX;
using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking
{
    public interface IThinking : IAbility
    {
        void ImplementBeliefs();
        void AddBelief( Action< IReality > realityAction );
        void AddBelief( IBelief belief );
        IReality InnerReality { get; }
        bool HasBelief( IBelief belief );
        void AddProcess( IThinkingProcess process );
        T GetProcess<T>() where T : IThinkingProcess;
    }
}