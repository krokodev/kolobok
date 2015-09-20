// Robotango (c) 2015 Krokodev
// Robotango.Core
// ImaginationProcess.cs

using Robotango.Common.Utils.Tools;
using Robotango.Core.Common;
using Robotango.Core.System;
using Robotango.Core.System.Imp;

namespace Robotango.Core.Abilities.Thinking.Processes.Imp
{
    public class ImaginationProcess : AbstractProcess, IImaginationProcess
    {
        #region Data

        private readonly IReality _innerReality = new Reality( Settings.Reality.Names.ImaginationProcess );

        #endregion


        #region Ctor

        public ImaginationProcess()
            : base( Lib.Thinking.Processes.Shemas.Imaginaton ) {}

        #endregion


        #region Overrides

        protected override void DumpProcessContent( OutlineWriter wr )
        {
            wr.Append( _innerReality.Dump( wr.Level ) );
        }

        #endregion


        #region IImaginationProcess

        IReality IImaginationProcess.InnerReality {
            get { return _innerReality; }
        }

        #endregion
    }
}