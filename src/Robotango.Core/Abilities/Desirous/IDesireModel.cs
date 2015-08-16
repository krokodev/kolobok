// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesireModel.cs

using System;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Desirous
{
    public interface IDesireModel<in T>
    {
        Func< IReality, IAgent, T, bool > Predicate { get; }
        string Name { get; }
    }
}