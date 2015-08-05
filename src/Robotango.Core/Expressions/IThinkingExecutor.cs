// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinkingExecutor.cs

using System;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public interface IThinkingExecutor
    {
        Action< IAgent > Know( IAgent other );
        Action< IAgent > Know( Func< IAgent, IAgent > selectOther );
        Func< IAgent, bool > Knowing( IAgent other );
    }
}