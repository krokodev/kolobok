// Robotango (c) 2015 Krokodev
// Robotango.Core
// Active.cs

using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.Internal.Agency;

// Here: Active

namespace Robotango.Core.Internal.Abilities
{
    internal class Active : Ability, IActive
    {
        #region Data

        private readonly IList< IOperation > _operations = new List< IOperation >();
        private readonly IList< IActivity > _activities = new List< IActivity >();

        #endregion


        #region Routines

        private void PassOperationsToReality( IReality reality )
        {
            // Code: Active.Proceed
            _operations.ForEach( reality.AddOperation );
            _operations.Clear();
        }

        private void DumpOperations( OutlineWriter wr )
        {
            if( !_operations.Any() ) {
                return;
            }
            wr.Line( "Operations" );
            wr.Level++;
            _operations.ForEach( o => wr.Append( o.Dump( wr.Level ) ) );
            wr.Level--;
        }
        private void DumpActivities( OutlineWriter wr )
        {
            if( !_activities.Any() ) {
                return;
            }
            wr.Line( "Activities" );
            wr.Level++;
            _activities.ForEach( a => wr.Append( a.Dump( wr.Level ) ) );
            wr.Level--;
        }

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new Active();
        }

        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            DumpOperations( wr );
            DumpActivities( wr );
        }

        #endregion


        #region IActive

        IOperation IActive.CreateOperation<T>( Action< IAgent, T > action, IAgent operand, T arg )
        {
            // Todo:> Use available Activities
            return new Operation< T >( action, operand, arg );
        }

        void IActive.AddOperation( IOperation operation )
        {
            _operations.Add( operation );
        }


        void IActive.AddActivity<T>( IActivity activity )
        {
            if( _activities.Contains( activity ) ) {
                return;
            }
            _activities.Add( activity );
        }

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality reality )
        {
            PassOperationsToReality( reality );
        }

        #endregion
    }
}