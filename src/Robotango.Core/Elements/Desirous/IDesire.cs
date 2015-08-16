// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Desirous
{
    public interface IDesire : IResearchable
    {
        bool IsSatisfiedIn( IReality reality );
        IAgent Subject { get; }
        object Arg { get; }
    }
}