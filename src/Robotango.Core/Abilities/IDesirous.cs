// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesirous.cs

using System;
using System.Collections.Generic;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Desirous;

namespace Robotango.Core.Abilities
{
    public interface IDesirous : IAbility
    {
        IList< IDesire > Desires { get; }
        void AddDesire( IDesire desire );
    }
}