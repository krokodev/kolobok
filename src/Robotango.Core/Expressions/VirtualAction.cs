// Robotango (c) 2015 Krokodev
// Robotango.Core
// VirtualAction.cs

using System;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;

namespace Robotango.Core.Expressions
{
    public class VirtualAction : ExpressionHelper< IAgent, IVirtual >, IVirtualAction
    {
        #region VirtualExecutor

        Action< IAgent > IVirtualAction.Position( Location location )
        {
            return agent => {
                var virt = ToExpressionType( agent );
                if( virt.Has< IPosition >() ) {
                    virt.Get< IPosition >().Location = location;
                } else {
                    virt.Add( new Position( location ) );
                }
            };
        }

        #endregion


        #region Ctor

        public VirtualAction( Func< IAgent, IVirtual > convertor )
            : base( convertor ) {}

        #endregion
    }
}