// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingExecutor.cs

using System;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public interface IThinkingExecutor
    {
        Action< IAgent > Introduce( IAgent agent );
        Action< IAgent > Introduce( Func< IAgent, IAgent > agentSelector );
    }
}