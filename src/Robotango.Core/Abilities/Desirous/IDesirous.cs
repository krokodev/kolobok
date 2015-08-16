// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesirous.cs

using System.Collections.Generic;

namespace Robotango.Core.Abilities.Desirous
{
    public interface IDesirous : IAbility
    {
        IList< IDesire > Desires { get; }
        void AddDesire( IDesire desire );
    }
}