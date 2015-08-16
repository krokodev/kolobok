// Robotango (c) 2015 Krokodev
// Robotango.Core
// IPosition.cs

using Robotango.Common.Types.Types;

namespace Robotango.Core.Elements.Virtual
{
    public interface IPosition : IAttribute
    {
        ILocation Location { get; set; }
    }
}