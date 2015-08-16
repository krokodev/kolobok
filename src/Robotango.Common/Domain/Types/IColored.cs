// Robotango (c) 2015 Krokodev
// Robotango.Common
// IColored.cs

using Robotango.Common.Domain.Enums;

namespace Robotango.Common.Domain.Types
{
    public interface IColored
    {
        Colors Color { get; set; }
    }
}