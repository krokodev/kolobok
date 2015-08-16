// Robotango (c) 2015 Krokodev
// Robotango.Core
// IWorld.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Abilities.Thinking;

namespace Robotango.Core.System
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