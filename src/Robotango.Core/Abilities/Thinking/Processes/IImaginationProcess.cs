// Robotango (c) 2015 Krokodev
// Robotango.Core
// IImaginationProcess.cs

using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes
{
    public interface IImaginationProcess : IThinkingProcess {
        IReality InnerReality { get; }
    }
}