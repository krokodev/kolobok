// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingExecutor.cs

using System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public class ThinkingExecutor : AgentProxy< IThinking >, IThinkingExecutor
    {
        #region IThinkingExecutor

        Action< IAgent > IThinkingExecutor.Introduce( IAgent other )
        {
            return agent => Convert( agent ).Imagination.Introduce( other );
        }

        public Action< IAgent > Introduce( Func< IAgent, IAgent > agentSelector )
        {
            return agent => Convert( agent ).Imagination.Introduce( agentSelector( agent ) );
        }

        #endregion


        public ThinkingExecutor( Func< IAgent, IThinking > convertor )
            : base( convertor ) {}
    }
}