// Robotango (c) 2015 Krokodev
// Robotango.Core
// Active.cs

using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Agency;
using Robotango.Core.Agency.Imp;
using Robotango.Core.Elements.Active;

// Here: Active

namespace Robotango.Core.Abilities.Imp
{
    internal class Active : Ability, IActive
    {
        #region Data

        private IList< IOperation > _operations = new List< IOperation >();
        private IList< IActivity > _activities = new List< IActivity >();

        #endregion


        #region Routines

        private void PassOperationsToReality( IReality reality )
        {
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
            return new Active {
                _operations = _operations.ToList(),
                _activities = _activities.ToList()
            };
        }

        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            DumpOperations( wr );
            DumpActivities( wr );
        }
        protected override void Proceed( IReality reality )
        {
            PassOperationsToReality( reality );
        }

        #endregion


        #region IActive

        IOperation IActive.CreateOperation<T>( IActivity activity, IAgent operand, T arg )
        {
            Debug.Assert.That( _activities.Contains( activity ), new UnknownActivityException( activity.Name ) );
            return new Operation< T >( activity, operand, arg );
        }

        void IActive.AddOperation( IOperation operation )
        {
            Debug.Assert.That( _activities.Contains( operation.Activity ), new UnknownActivityException( operation.Activity.Name ) );
            _operations.Add( operation );
        }

        void IActive.AddActivity( IActivity activity )
        {
            if( _activities.Contains( activity ) ) {
                return;
            }
            _activities.Add( activity );
        }

        bool IActive.ContainsOperation<T>( IActivity activity, IAgent operand, T arg )
        {
            return _operations.Any(op=>op.Activity==activity && op.Operand == operand && op.Arg.Equals( arg ) );
        }

        #endregion

    }
}