// Robotango (c) 2015 Krokodev
// Robotango.Core
// ImaginationProcess.cs

using Robotango.Core.Common;
using Robotango.Core.System;
using Robotango.Core.System.Imp;

namespace Robotango.Core.Abilities.Thinking.Processes.Imp
{
    public class ImaginationProcess : ThinkingProcess, IImaginationProcess
    {
        #region Data

        private readonly IReality _reality = new Reality();

        #endregion


        #region Ctor

        public ImaginationProcess()
            : base( Lib.Thinking.Processes.Shemas.Imagination ) {}


        #endregion

    }
}