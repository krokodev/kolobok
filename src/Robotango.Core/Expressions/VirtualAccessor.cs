// Robotango (c) 2015 Krokodev
// Robotango.Core
// VirtualAccessor.cs

using System;
using Robotango.Common.Domain.Implements.Expressions;
using Robotango.Common.Domain.Types.Expressions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;

namespace Robotango.Core.Expressions
{
    public class VirtualAccessor : AgentAccessor< IAgent, IVirtual >, IVirtualAccessor
    {
        #region IVirtualAccessor

        IPropertyAccessor< IAgent, IPosition > IVirtualAccessor.Position
        {
            get { return new PropertyAccessor< IAgent, IPosition >( GetPosition, SetPosition ); }
        }

        IPropertyAccessor< IAgent, ILocation > IVirtualAccessor.Location
        {
            get { return new PropertyAccessor< IAgent, ILocation >( GetLocation, SetLocation ); }
        }

        #endregion


        #region Ctor

        public VirtualAccessor( Func< IAgent, IVirtual > convertor )
            : base( convertor ) {}

        #endregion


        #region Routines

        private void SetPosition( IAgent agent, IPosition position )
        {
            Convert( agent ).Add( position );
        }

        private IPosition GetPosition( IAgent agent )
        {
            return Convert( agent ).Get< IPosition >();
        }

        private ILocation GetLocation( IAgent agent )
        {
            return Convert( agent ).Get< IPosition >().Location;
        }

        private void SetLocation( IAgent agent, ILocation location )
        {
            Convert( agent ).Set< Position, ILocation >(
                ( p, l ) => SetLocation( p, l ),
                location
                );
        }

        private static ILocation SetLocation( Position p, ILocation l )
        {
            return p.IPosition.Location = l;
        }

        #endregion
    }
}