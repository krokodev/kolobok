// Robotango (c) 2015 Krokodev
// Robotango.Core
// IPurposeful.cs

using System;
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Interfaces.Abilities
{
    public interface IPurposeful : IAbility
    {
        IIntention Intends( Func< IReality, bool > predicate, string name = null );
    }
}