﻿// Robotango (c) 2015 Krokodev
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
        #region Data

        private List< IBelief > _beliefs = new List< IBelief >();
        private IReality _innerReality = new Reality( Settings.Agents.Thinking.InnerReality.Name );

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new Thinking {
                _beliefs = _beliefs.ToList(),
                _innerReality = _innerReality.Clone()
            };
        }

        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            wr.Append( _innerReality.Dump( wr.Level ) );
        }

        #endregion


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


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality reality )
        {
            _beliefs.ForEach( belief => belief.Essence.Invoke( _innerReality ) );

            _innerReality.Agents.ForEach( agent => agent.Proceed( _innerReality ) );

            _innerReality.Proceed();

            //MakeDecision();
            //UpdateInnerReality();
        }

        #endregion
    }
}