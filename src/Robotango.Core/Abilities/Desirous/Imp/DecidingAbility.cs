// Robotango (c) 2015 Krokodev
// Robotango.Core
// DecidingAbility.cs

using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Robotango.Common.Types.Compositions;
using Robotango.Common.Types.Types;
using Robotango.Core.Abilities.Active;
using Robotango.Core.Abilities.Active.Imp;
using Robotango.Core.Common;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Desirous.Imp
{
    internal class DecidingAbility : Ability, IDeciding
    {
        #region Data
        private IActive _active;
        private IDesirous _desirous;
        private IList< IIntention > _intentions;
        #endregion


        #region Routines
        private IList< IDesire > ObtainDesires()
        {
            if( _desirous == null )
                return null;

            return _desirous.Desires;
        }

        private IList< IActivity > ObtainActivities()
        {
            if( _active == null )
                return null;

            return _active.Activities;
        }

        private IList< IIntention > MakeDecision(
            IReality reality,
            IList< IDesire > desires,
            IList< IActivity > activities )
        {
            var intentions = new List< IIntention >();

            if( desires == null )
                return null;

            // Todo:> Use class DecisionAlgorithms
            var desire = desires.FirstOrDefault( d => d is ILocationDesire );
            if( desire == null )
                return null;

            var intention = new Intention< ILocation >(
                Lib.Activities.Movement,
                desire.Subject,
                ( ILocation ) desire.Arg );

            intentions.Add( intention );
            return intentions;
        }

        private void PassIntentionsToActive()
        {
            if( _intentions == null || _active == null )
                return;

            _intentions.ForEach( i => _active.AddIntention( i.Activity, i.Operand, i.Arg ) );
            _intentions.Clear();
        }
        #endregion


        #region Overrides
        protected override IComponent Clone()
        {
            return new DecidingAbility();
        }

        protected override void Proceed( IReality reality )
        {
            PassIntentionsToActive();
        }

        protected override void onInitAsComponent()
        {
            _active = MakeDependenceIfAvailable< IActive >();
            _desirous = MakeDependenceIfAvailable< IDesirous >();
        }
        #endregion


        #region IDeciding
        void IDeciding.MakeDecision( IReality reality )
        {
            var desires = ObtainDesires();
            var activities = ObtainActivities();
            _intentions = MakeDecision( reality, desires, activities );
        }
        #endregion
    }
}