// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAbility.cs

using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Interfaces.Agency
{
    public interface IAbility : IComponent, IProceedable< IReality >, IResearchable {}
}