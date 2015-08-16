// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAbility.cs

using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;

namespace Robotango.Core.Abilities
{
    public interface IAbility : IComponent, IProceedable< IReality >, IResearchable {}
}