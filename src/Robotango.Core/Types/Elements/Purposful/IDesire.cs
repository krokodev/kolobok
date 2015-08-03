// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Core.Types.Agency;

namespace Robotango.Core.Types.Elements.Purposful
{
    public interface IDesire
    {
        IReality Reality { get; }
        bool IsSatisfied { get; }
    }
}