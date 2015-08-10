// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Purposeful
{
    public interface IDesire : IResearchable
    {
        IAgent Holder { get; }
        IReality Context { get; }
        bool IsSatisfied();
    }
}