// Robotango (c) 2015 Krokodev
// Robotango.Expressions
// IThinkingExecutor.cs

using System;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Thinking.Beliefs_XXX;
using Robotango.Core.System;

namespace Robotango.Expressions.Terms
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