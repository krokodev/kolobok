// Robotango (c) 2015 Krokodev
// Robotango.Core
// RationalProcess.cs

using Robotango.Common.Utils.Tools;
using Robotango.Core.Common;

namespace Robotango.Core.Abilities.Thinking.Processes.Imp
{
    public class RationalProcess : AbstractProcess
    {
        #region Ctor

        public RationalProcess()
            : base( Lib.Thinking.Processes.Shemas.Rational ) {}

        #endregion


        #region Overrides

        protected override void DumpProcessContent( OutlineWriter wr ) {}

        #endregion
    }
}