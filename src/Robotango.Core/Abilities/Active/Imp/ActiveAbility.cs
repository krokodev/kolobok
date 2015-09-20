// Robotango (c) 2015 Krokodev
// Robotango.Core
// ActiveAbility.cs

using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Robotango.Common.Types.Compositions;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.System;

// Here: Active

namespace Robotango.Core.Abilities.Active.Imp
{
    internal class ActiveAbility : Ability, IActive
    {
        #region Data

        private IList< IIntention > _intentions = new List< IIntention >();
        private IList< IActivity > _activities = new List< IActivity >();

        #endregion


        #region Routines

        private void PassInentionsToReality( IReality reality )
        {
            _intentions.ForEach( i => reality.AddOperation( i.Activity, i.Operand, i.Arg ) );
            _intentions.Clear();
        }

        private void DumpActivities( OutlineWriter wr )
        {
            if( !_activities.Any() )
                return;
            wr.Line( "Activities" );
            wr.Level++;
            _activities.ForEach( a => wr.Append( a.Dump( wr.Level ) ) );
            wr.Level--;
        }

        private void DumpIntentions( OutlineWriter wr )
        {
            if( !_intentions.Any() )
                return;
            wr.Line( "Intentions" );
            _intentions.ForEach( i => wr.Append( i.Dump( wr.Level + 1 ) ) );
        }

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new ActiveAbility {
                _intentions = _intentions.ToList(),
                _activities = _activities.ToList()
            };
        }

        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            DumpActivities( wr );
            DumpIntentions( wr );
        }

        protected override void Proceed( IReality reality )
        {
            PassInentionsToReality( reality );
        }

        #endregion


        #region IActive

        void IActive.AddActivity( IActivity activity )
        {
            if( _activities.Contains( activity ) )
                return;
            _activities.Add( activity );
        }

        bool IActive.ContainsIntention<T>( IActivity activity, IAgent operand, T arg )
        {
            return _intentions.Any( op => op.Activity == activity && op.Operand == operand && op.Arg.Equals( arg ) );
        }

        void IActive.AddIntention<T>( IActivity activity, IAgent operand, T arg )
        {
            Debug.Assert.That( _activities.Contains( activity ), new UnknownActivityException( activity.Name ) );
            _intentions.Add( new Intention< T >( activity, operand, arg ) );
        }

        IList< IActivity > IActive.Activities {
            get { return _activities; }
        }

        #endregion
    }
}