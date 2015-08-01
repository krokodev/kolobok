// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttribute.cs

namespace Robotango.Core.Types.Attributes
{
    public interface IAttribute
    {
        IAttribute Clone();
        IAttributeHolder Holder { get; set; }
    }
}