// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Purposeful
{
    public interface IDesire : IResearchable
    {
        bool IsSatisfiedIn( IReality reality);
    }
}