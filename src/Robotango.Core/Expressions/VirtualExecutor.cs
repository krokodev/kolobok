// Robotango (c) 2015 Krokodev
// Robotango.Core
// VirtulaProxy.cs

using System;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public class VirtualExecutor : ExpressionHelper<IAgent, IVirtual>, IVirtualExecutor
    {
        #region VirtualExecutor

        Action< IAgent > IVirtualExecutor.Position( Location location )
        {
            return agent => ToExpressionType( agent ).Add( new Position( location ) );
        }

        #endregion


        #region Ctor

        public VirtualExecutor( Func< IAgent, IVirtual > convertor )
            : base( convertor ) {}

        #endregion
    }
}