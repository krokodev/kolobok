// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingProcessSchema.cs

using System;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes
{
    public interface IThinkingProcessSchema
    {
        Func< IThinkingProcess, IReality > InputRealitySelector { get; }
        string Name { get; }
    }
}