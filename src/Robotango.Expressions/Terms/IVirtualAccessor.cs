// Robotango (c) 2015 Krokodev
// Robotango.Expressions
// IVirtualAccessor.cs

using Robotango.Common.Types.Expressions;
using Robotango.Common.Types.Types;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Virtual;

namespace Robotango.Expressions.Terms
{
    public interface IVirtualAccessor
    {
        IPropertyAccessor< IAgent, IPosition > Position { get; }
        IPropertyAccessor< IAgent, ILocation > Location { get; }
    }
}