// Robotango (c) 2015 Krokodev
// Robotango.Core
// IWorld.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Interfaces.Abilities;

namespace Robotango.Core.Interfaces.Agency
{
    public interface IWorld : IResearchable
    {
        IReality IReality { get; }
        IThinking IThinking { get; }
        string Name { get; set; }
        IAgent IAgent { get; }
        void Proceed();
        IAgent GetAgent( IAgent agent );
    }
}