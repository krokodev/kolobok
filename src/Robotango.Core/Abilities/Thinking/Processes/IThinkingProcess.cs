// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingProcess.cs

using Robotango.Common.Types.Types;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes
{
    public interface IThinkingProcess : IResearchable
    {
        IReality InputReality { get; }
    }
}