// Robotango (c) 2015 Krokodev
// Robotango.Core
// VirtualProxy.cs

using System;
using Robotango.Common.Domain.Implements.Expressions;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;

namespace Robotango.Core.Expressions
{
    public class VirtualAccessor : AgentAccessor< IAgent, IVirtual >, IVirtualAccessor
    {
        #region IVirtualGetter

        public PropertyAccessor< IAgent, IPosition > Position
        {
            get
            {
                return new PropertyAccessor< IAgent, IPosition > {
                    Get = agent => Convert( agent ).Get< IPosition >()
                };
            }
        }

        #endregion


        #region Ctor

        public VirtualAccessor( Func< IAgent, IVirtual > convertor )
            : base( convertor ) {}

        #endregion
    }
}