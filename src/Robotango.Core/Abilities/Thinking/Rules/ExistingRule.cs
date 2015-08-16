// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ExistingPrinciple.cs

using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Rules
{
    public class ExistingRule : IThinkingRule
    {
        #region Data

        private readonly IAgent _subject;

        #endregion


        #region Ctor

        public ExistingRule( IAgent subject )
        {
            _subject = subject;
        }

        #endregion


        #region IThinkingProcessRule

        void IThinkingRule.Apply( IReality reality )
        {
            if( reality.Contains( _subject ) ) {
                return;
            }
            reality.AddAgent( _subject );
        }

        #endregion
    }
}