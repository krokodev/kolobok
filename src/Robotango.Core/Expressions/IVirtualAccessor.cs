// Robotango (c) 2015 Krokodev
// Robotango.Core
// IVirtualAccessor.cs

using Robotango.Common.Domain.Types.Expressions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;

namespace Robotango.Core.Expressions
{
    public interface IVirtualAccessor
    {
        IPropertyAccessor< IAgent, IPosition > Position { get; }
        IPropertyAccessor< IAgent, ILocation > Location { get; }
    }
}