// Robotango (c) 2015 Krokodev
// Robotango.Core
// IIntention.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Types.Elements.Purposful
{
    public interface IIntention : IResearchable
    {
        IAgent Holder { get; }
        IReality Context { get; }
        bool IsSatisfied { get; }
    }
}