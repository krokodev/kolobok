// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttribute.cs

using Robotango.Core.Types.Skills;

namespace Robotango.Core.Types.Common
{
    public interface IAttribute
    {
        IAttribute Clone();
        IEntity Entity { get; set; }
    }
}