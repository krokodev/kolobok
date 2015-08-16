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

        private readonly IThinkingProcessSchema _schema;

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
            return _schema.InputRealitySelector( this );
        }

        #endregion


        #region Overrides
        protected abstract void DumpProcessContent( OutlineWriter wr );

        #endregion

        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );

            wr.Indent();
            wr.Append( "<{0}>", GetType().Name );
            wr.Level++;
            DumpProcessContent( wr );
            return wr.ToString();
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