// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingProcessSchema.cs

using System;
using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Schemas
{
    public interface IThinkingSchema
    {
        string Name { get; }
        Func< IThinkingProcess, IReality > InputRealitySelector { get; }
        Func< IThinkingProcess, IReality > OutputRealitySelector { get; }
        Action< IThinkingProcess> Proceed { get; }
    }
}