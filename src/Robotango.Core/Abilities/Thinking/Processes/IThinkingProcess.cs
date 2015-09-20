// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingProcess.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Abilities.Thinking.Rules;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes
{
    public interface IThinkingProcess : IResearchable, IProceedable< IReality >
    {
        IReality InputReality { get; }
        IReality OutputReality { get; }
        void AddRule( IThinkingRule rule );
        void ApplyRules( IReality reality );
    }
}