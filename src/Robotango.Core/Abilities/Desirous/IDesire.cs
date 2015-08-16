// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesire.cs

using Robotango.Common.Types.Types;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Desirous
{
    public interface IDesire : IResearchable
    {
        bool IsSatisfiedIn( IReality reality );
        IAgent Subject { get; }
        object Arg { get; }
    }
}