// Robotango (c) 2015 Krokodev
// Robotango.Core
// IPurposeful.cs

using System;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;

namespace Robotango.Core.Abilities
{
    public interface IPurposeful : IAbility
    {
        IDesire AddDesire( Func< IReality, bool > predicate, string name = null );
        IIntention AddIntention( IOperation operation );
    }
}