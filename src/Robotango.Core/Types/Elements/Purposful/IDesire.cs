// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Core.Types.Agency;

namespace Robotango.Core.Types.Elements.Purposful
{
    public interface IDesire
    {
        IReality Context { get; }
        bool IsSatisfied { get; }
    }
}