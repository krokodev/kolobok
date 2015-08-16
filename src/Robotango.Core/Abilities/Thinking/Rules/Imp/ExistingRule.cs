// Robotango (c) 2015 Krokodev
// Robotango.Core
// ExistingRule.cs

using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Rules.Imp
{
    public class ExistingRule : AbstractRule
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

        protected override void Apply( IReality reality )
        {
            if( reality.Contains( _subject ) ) {
                return;
            }
            reality.AddAgent( _subject );
        }

        #endregion
    }
}