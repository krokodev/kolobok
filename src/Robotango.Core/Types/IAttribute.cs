// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttribute.cs

namespace Robotango.Core.Types
{
    public interface IAttribute
    {
        IAttribute Clone();
        IEntity Entity { get; set; }
    }
}