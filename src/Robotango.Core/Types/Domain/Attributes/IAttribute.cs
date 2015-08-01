// Robotango (c) 2015 Krokodev
// Robotango.Common
// IAttribute.cs

namespace Robotango.Core.Types.Domain.Attributes
{
    public interface IAttribute
    {
        IAttribute Clone();
        IAttributeHolder Holder { get; set; }
    }
}