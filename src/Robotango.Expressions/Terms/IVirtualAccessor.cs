// Robotango (c) 2015 Krokodev
// Robotango.Expressions
// IVirtualAccessor.cs

using Robotango.Common.Domain.Types.Expressions;
using Robotango.Common.Domain.Types.Properties;
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