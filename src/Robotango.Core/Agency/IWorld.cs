// Robotango (c) 2015 Krokodev
// Robotango.Core
// IWorld.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Abilities;

namespace Robotango.Core.Agency
{
    public interface IWorld : IResearchable
    {
        IReality IReality { get; }
        IThinking IThinking { get; }
        string Name { get; }
        void Proceed();
        IAgent GetAgent( IAgent agent );
    }
}