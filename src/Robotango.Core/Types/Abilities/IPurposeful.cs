// Robotango (c) 2015 Krokodev
// Robotango.Core
// IPurposeful.cs

using System;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Purposful;

namespace Robotango.Core.Types.Abilities
{
    public interface IPurposeful : IAbility
    {
        IDesire AddDesire( Func< IReality, bool > goal );
    }
}