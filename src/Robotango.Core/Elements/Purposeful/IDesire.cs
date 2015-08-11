// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Elements.Purposeful
{
    public interface IDesire : IResearchable
    {
        bool IsSatisfied();
    }
}