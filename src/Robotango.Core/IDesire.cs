// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Core.Types.Agency;

namespace Robotango.Core
{
    public interface IDesire {
        IReality Reality { get; }
        bool IsSatisfied { get; }
    }
}