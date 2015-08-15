// Robotango (c) 2015 Krokodev
// Robotango.Core
// Purposeful.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Agency;
using Robotango.Core.Agency.Imp;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;

// Here: Purposeful

namespace Robotango.Core.Abilities.Imp
{
    internal class Purposeful : Ability, IPurposeful
    {
        #region Data

        private IThinking _thinking;
        private IActive _active;
        private List< IDesire > _desires = new List< IDesire >();
        private List< IIntention > _intentions = new List< IIntention >();

        #endregion


        #region Routines

        private void PassIntentionsToActiveComponent()
        {
            if( _active == null ) {
                return;
            }

            _intentions.ForEach( i => _active.AddOperation( i.Operation ) );
            _intentions.Clear();
        }

        private void DumpIntentions( OutlineWriter wr )
        {
            if( !_intentions.Any() ) {
                return;
            }
            wr.Line( "Intentions" );
            _intentions.ForEach( i => wr.Append( i.Dump( wr.Level + 1 ) ) );
        }

        private void DumpDesires( OutlineWriter wr )
        {
            if( !_desires.Any() ) {
                return;
            }
            wr.Line( "Desires" );
            _desires.ForEach( d => wr.Append( d.Dump( wr.Level + 1 ) ) );
        }

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new Purposeful {
                _desires = _desires.ToList(),
                _intentions = _intentions.ToList()
            };
        }

        protected override void onInitAsComponent()
        {
            _thinking = MakeDependence< IThinking >();
            _active = MakeDependenceIfAvailable< IActive >();
        }

        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            DumpDesires( wr );
            DumpIntentions( wr );
        }

        #endregion


        #region IPurposeful

        IDesire IPurposeful.AddDesire( Func< IReality, bool > predicate, string name )
        {
            var desire = new Desire( _thinking.InnerReality, predicate, name );
            _desires.Add( desire );
            return desire;
        }

        IIntention IPurposeful.AddIntention( IOperation operation )
        {
            var intention = new Intention( operation );
            _intentions.Add( intention );
            return intention;
        }

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality reality )
        {
            PassIntentionsToActiveComponent();
        }

        #endregion
    }
}