// Robotango (c) 2015 Krokodev
// Robotango.Common
// IAttribute.cs

namespace Robotango.Common.Types.Attributes
{
    public interface IAttribute
    {
        IAttribute Clone();
        IAttributeHolder Holder { get; set; }
    }
}