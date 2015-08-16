// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingProcess.cs

using Robotango.Common.Types.Types;
using Robotango.Common.Utils.Tools;

namespace Robotango.Core.Abilities.Thinking.Imp
{
    public abstract class ThinkingProcess : IThinkingProcess
    {
        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level,
                "<{0}>",
                GetType().Name
                );
        }

        #endregion
    }
}