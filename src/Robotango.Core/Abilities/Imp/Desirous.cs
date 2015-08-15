// Robotango (c) 2015 Krokodev
// Robotango.Core
// Desirous.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Agency;
using Robotango.Core.Agency.Imp;
using Robotango.Core.Elements.Purposeful;

namespace Robotango.Core.Abilities.Imp
{
    internal class Desirous : Ability, IDesirous
    {
        #region Data

        private List< IDesire > _desires = new List< IDesire >();

        #endregion


        #region Routines

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
            return new Desirous {
                _desires = _desires.ToList()
            };
        }

        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            DumpDesires( wr );
        }

        #endregion


        #region IDesirous

        IDesire IDesirous.AddDesire( Func< IReality, bool > predicate, string name )
        {
            var desire = new Desire( predicate, name );
            _desires.Add( desire );
            return desire;
        }

        #endregion
    }
}