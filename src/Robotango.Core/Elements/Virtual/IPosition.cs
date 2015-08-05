// Robotango (c) 2015 Krokodev
// Robotango.Core
// IPosition.cs

using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Elements.Virtual
{
    public interface IPosition : IAttribute
    {
        ILocation Location { get; set; }
    }
}