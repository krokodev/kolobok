// Robotango (c) 2015 Krokodev
// Robotango.Expressions
// IVirtualAccessor.cs

using Robotango.Common.Types.Expressions;
using Robotango.Common.Types.Types;
using Robotango.Core.Abilities.Virtual;
using Robotango.Core.System;

namespace Robotango.Expressions.Terms
{
    public interface IVirtualAccessor
    {
        IPropertyAccessor< IAgent, IPosition > Position { get; }
        IPropertyAccessor< IAgent, ILocation > Location { get; }
    }
}