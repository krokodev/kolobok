// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingProcess.cs

using Robotango.Common.Types.Types;
using Robotango.Common.Utils.Tools;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes.Imp
{
    public abstract class ThinkingProcess : IThinkingProcess
    {
        #region Data

        private IThinkingProcessSchema _schema;

        #endregion


        #region Ctor

        protected ThinkingProcess( IThinkingProcessSchema schema )
        {
            _schema = schema;
        }

        #endregion



        #region Routines

        private IReality GetInputReality()
        {
            return _schema.InputRealitySelector(this);
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level,
                "<{0}>",
                GetType().Name
                );
        }

        #endregion


        #region IThinkingProcess

        IReality IThinkingProcess.InputReality
        {
            get { return GetInputReality(); }
        }

        #endregion
    }
}