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
    public class VirtualSetter : ExpressionHelper< IAgent, IVirtual >, IVirtualSetter
    {
        #region VirtualExecutor

        Action< IAgent > IVirtualSetter.Position( ILocation location )
        {
            return agent => ToExpressionType( agent )
                .Set< Position, ILocation >( ( p, l ) => p.IPosition.Location = l, location );
        }

        #endregion


        #region Ctor

        public VirtualSetter( Func< IAgent, IVirtual > convertor )
            : base( convertor ) {}

        #endregion
    }
}