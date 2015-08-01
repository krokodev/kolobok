// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttribute.cs

using Robotango.Core.Types.Domain.Abilities;

namespace Robotango.Core.Types.Attributes
{
    public interface IAttribute
    {
        IAttribute Clone();
        IVirtual Virtual { get; set; }
    }
}