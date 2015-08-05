// Robotango (c) 2015 Krokodev
// Robotango.Core
// IWorld.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Interfaces.Abilities;

namespace Robotango.Core.Interfaces.Agency
{
    public interface IWorld : INamed, IResearchable
    {
        IReality Reality { get; }
        IThinking Thinking { get; }
    }
}