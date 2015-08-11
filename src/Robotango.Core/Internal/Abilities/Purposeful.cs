// Robotango (c) 2015 Krokodev
// Robotango.Core
// Purposeful.cs

using System;
using System.Collections.Generic;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.Internal.Agency;

// Here: Purposeful

namespace Robotango.Core.Internal.Abilities
{
    internal class Purposeful : Ability, IPurposeful
    {
        #region IPurposeful

        IDesire IPurposeful.AddDesire( Func< IReality, bool > predicate, string name )
        {
            var desire = new Desire( _thinking.InnerReality, predicate, name );
            _desires.Add( desire );
            return desire;
        }

        IIntention IPurposeful.AddIntention( IOperation operation, string name )
        {
            var intention = new Intention( operation, name );
            _intentions.Add( intention );
            return intention;
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Purposeful ).Name );
            wr.Level ++;

            wr.Line( "Desires" );
            _desires.ForEach( d => wr.Append( d.Dump( wr.Level + 1 ) ) );

            wr.Line( "Intentions" );
            _intentions.ForEach( i => wr.Append( i.Dump( wr.Level + 1 ) ) );

            return wr.ToString();
        }

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality reality ) {}

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new Purposeful();
        }

        protected override void InitAsComponent()
        {
            _thinking = MakeDependence< IThinking >();
        }

        #endregion


        #region Fields

        private IThinking _thinking;
        private readonly List< IDesire > _desires = new List< IDesire >();
        private readonly List< IIntention > _intentions = new List< IIntention >();

        #endregion
    }
}