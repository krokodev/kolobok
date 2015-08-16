// Robotango (c) 2015 Krokodev
// Robotango.Core
// IProcessBelief.cs

using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Rules
{
    public interface IThinkingRule {
        void Apply( IReality reality );
    }
}