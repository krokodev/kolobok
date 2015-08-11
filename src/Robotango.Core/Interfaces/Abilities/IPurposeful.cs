// Robotango (c) 2015 Krokodev
// Robotango.Core
// IPurposeful.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Interfaces.Abilities
{
    public interface IPurposeful : IAbility, IResearchable, IProceedable
    {
        IDesire AddDesire( Func< IReality, bool > predicate, string name = null );
        IIntention AddIntention( IOperation operation, string name = null );
    }
}