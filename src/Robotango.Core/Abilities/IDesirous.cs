// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDesirous.cs

using System;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Purposeful;

namespace Robotango.Core.Abilities
{
    public interface IDesirous : IAbility
    {
        IDesire AddDesire( Func< IReality, bool > predicate, string name = null );
    }
}