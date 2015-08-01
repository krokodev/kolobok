// Robotango (c) 2015 Krokodev
// Robotango.Common
// IColored.cs

using Robotango.Common.Domain.Types.Enums;

namespace Robotango.Common.Domain.Types.Properties
{
    public interface IColored
    {
        Colors Color { get; set; }
    }
}