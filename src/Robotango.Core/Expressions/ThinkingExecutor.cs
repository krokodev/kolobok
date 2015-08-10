// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingExecutor.cs

using System;
using Robotango.Core.Elements.Thinking;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Expressions
{
    public class ThinkingExecutor : AgentProxy< IThinking >, IThinkingExecutor
    {
        #region IThinkingExecutor

        Action< IAgent > IThinkingExecutor.Know( IAgent other )
        {
            return self => Convert( self ).InnerReality.AddAgent( other );
        }

        public Action< IAgent > Know( Func< IAgent, IAgent > selectOther )
        {
            return self => Convert( self ).InnerReality.AddAgent( selectOther( self ) );
        }

        public Func< IAgent, bool > Knowing( IAgent other )
        {
            return self => Convert( self ).InnerReality.Contains( other );
        }

        public Action< IAgent > Believe( IBelief belief )
        {
            return self => Convert( self ).AddBelief( belief );
        }

        Func< IAgent, bool > IThinkingExecutor.Believing( IBelief belief )
        {
            return self => Convert( self ).HasBelief( belief );
        }

        #endregion


        public ThinkingExecutor( Func< IAgent, IThinking > convertor )
            : base( convertor ) {}
    }
}