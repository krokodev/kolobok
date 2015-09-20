// Robotango (c) 2015 Krokodev
// Robotango.Core
// AbstractRule.cs

using Robotango.Common.Types.Types;
using Robotango.Common.Utils.Tools;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Rules.Imp
{
    public abstract class AbstractRule : IThinkingRule
    {
        #region Overrides

        protected abstract void Apply( IReality reality );

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level, "<{0}>", GetType().Name );
        }

        #endregion


        #region IThinkingRule

        void IThinkingRule.Apply( IReality reality )
        {
            Apply( reality );
        }

        #endregion
    }
}