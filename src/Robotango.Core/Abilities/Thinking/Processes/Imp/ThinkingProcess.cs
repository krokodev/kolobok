// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingProcess.cs

using System.Collections.Generic;
using MoreLinq;
using Robotango.Common.Types.Types;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Abilities.Thinking.Rules;
using Robotango.Core.Abilities.Thinking.Schemas;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes.Imp
{
    public abstract class ThinkingProcess : IThinkingProcess
    {
        #region Data

        private readonly IThinkingSchema _schema;
        private readonly IList< IThinkingRule > _rules = new List< IThinkingRule >();

        #endregion


        #region Ctor

        protected ThinkingProcess( IThinkingSchema schema )
        {
            _schema = schema;
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

        private IThinkingProcess IThinkingProcess
        {
            get { return this; }
        }

        IReality IThinkingProcess.InputReality
        {
            get { return _schema.InputRealitySelector( this ); }
        }

        IReality IThinkingProcess.OutputReality
        {
            get { return _schema.OutputRealitySelector( this ); }
        }

        void IThinkingProcess.AddRule( IThinkingRule rule )
        {
            _rules.Add( rule );
        }

        public void ApplyRules( IReality reality )
        {
            _rules.ForEach( r=>r.Apply( reality ) );
        }

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality context )
        {
            _schema.Proceed( this );
        }

        #endregion
    }
}