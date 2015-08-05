// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingExecutor.cs

using System;
using Robotango.Core.Elements.Thinking;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Expressions
{
    public interface IThinkingExecutor
    {
        Action< IAgent > Know( IAgent other );
        Action< IAgent > Know( Func< IAgent, IAgent > selectOther );
        Func< IAgent, bool > Knowing( IAgent other );
        Action< IAgent > Believe( IBelief belief );
        Func< IAgent, bool > Believing( IBelief belief );
    }
}