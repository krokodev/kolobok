// Robotango (c) 2015 Krokodev
// Robotango.Core
// VirtualSetter.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public class VirtualSetter : AgentAccessor< IAgent, IVirtual >, IVirtualSetter
    {
        #region IVirtualSetter

        Action< IAgent > IVirtualSetter.Position( ILocation location )
        {
            return agent => Convert( agent )
                .Set< Position, ILocation >( ( p, l ) => p.IPosition.Location = l, location );
        }

        #endregion


        #region Ctor

        public VirtualSetter( Func< IAgent, IVirtual > convertor )
            : base( convertor ) {}

        #endregion
    }
}