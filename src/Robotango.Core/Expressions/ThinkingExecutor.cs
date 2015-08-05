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

        Action< IAgent > IThinkingExecutor.Know( IAgent other )
        {
            return self => Convert( self ).Imagination.Introduce( other );
        }

        public Action< IAgent > Know( Func< IAgent, IAgent > selectOther )
        {
            return self => Convert( self ).Imagination.Introduce( selectOther( self ) );
        }

        public Func< IAgent, bool > Knowing( IAgent other )
        {
            return self => Convert( self ).Imagination.Contains( other );
        }

        #endregion


        public ThinkingExecutor( Func< IAgent, IThinking > convertor )
            : base( convertor ) {}
    }
}