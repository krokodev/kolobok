// Robotango (c) 2015 Krokodev
// Robotango.Core
// Thinking.cs

using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Thinking;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.Internal.Agency;
using Robotango.Core.System;

// Here: Thinking 

namespace Robotango.Core.Internal.Abilities
{
    internal class Thinking : Ability, IThinking
    {
        #region IThinking

        private IThinking IThinking
        {
            get { return this; }
        }

        IReality IThinking.InnerReality
        {
            get { return _innerReality; }
        }

        void IThinking.ImplementBeliefs()
        {
            _beliefs.ForEach( belief => belief.Essence.Invoke( _innerReality ) );
        }

        void IThinking.AddBelief( IBelief belief )
        {
            _beliefs.Add( belief );
        }

        void IThinking.AddBelief( Action< IReality > realityAction )
        {
            IThinking.AddBelief( new Belief( realityAction ) );
        }

        bool IThinking.HasBelief( IBelief belief )
        {
            return _beliefs.Contains( belief );
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Thinking ).Name );
            wr.Append( _innerReality.Dump( wr.Level + 1 ) );
            return wr.ToString();
        }

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality reality )
        {
            InitInnerReality();
            MakePrediction();
            MakeDecision();
            UpdateInnerReality();
        }

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new Thinking {
                _beliefs = _beliefs.ToList(),
                _innerReality = _innerReality.Clone()
            };
        }

        #endregion


        #region Routines

        private void InitInnerReality()
        {
            _beliefs.ForEach( belief => belief.Essence.Invoke( _innerReality ) );
        }

        private void MakePrediction()
        {
            _innerReality.Agents.ForEach( agent => agent.Proceed( _innerReality ) );
        }

        private void MakeDecision() {}

        private void UpdateInnerReality() {}

        #endregion


        #region Fields

        private List< IBelief > _beliefs = new List< IBelief >();
        private IReality _innerReality = new Reality( Settings.Agents.Thinking.InnerReality.Name );

        #endregion
    }
}