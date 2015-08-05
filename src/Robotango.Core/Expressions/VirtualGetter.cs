// Robotango (c) 2015 Krokodev
// Robotango.Core
// VirtualGetter.cs

using System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;

namespace Robotango.Core.Expressions
{
    public class VirtualGetter : ExpressionHelper< IAgent, IVirtual >, IVirtualGetter
    {
        #region IVirtualGetter

        public Func< IAgent, IPosition > Position
        {
            get { return agent => ToExpressionType( agent ).Get< IPosition >(); }
        }

        #endregion


        #region Ctor

        public VirtualGetter( Func< IAgent, IVirtual > convertor )
            : base( convertor ) {}

        #endregion
    }
}