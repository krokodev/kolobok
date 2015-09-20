// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingRule.cs

using Robotango.Common.Types.Types;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Rules
{
    public interface IThinkingRule : IResearchable
    {
        void Apply( IReality reality );
    }
}