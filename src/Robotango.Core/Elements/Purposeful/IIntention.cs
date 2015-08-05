// Robotango (c) 2015 Krokodev
// Robotango.Core
// IIntention.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Purposeful
{
    public interface IIntention : IResearchable
    {
        IAgent Holder { get; }
        IReality Context { get; }
        bool IsSatisfied();
    }
}