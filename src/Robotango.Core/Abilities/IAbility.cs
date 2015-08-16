// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAbility.cs

using Robotango.Common.Types.Compositions;
using Robotango.Common.Types.Types;
using Robotango.Core.System;

namespace Robotango.Core.Abilities
{
    public interface IAbility : IComponent, IProceedable< IReality >, IResearchable {}
}