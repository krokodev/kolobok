// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAgent.cs

using Robotango.Core.Types.Common;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Types.Agents
{
    public interface IAgent : IIdentifiable, IResearchable
    {
        T As<T>();
        IAgent Clone();
        IWorld Reality { get; set; }
        string Name { get; set; }
        uint Depth { get; }
        string FullName { get; }
        bool HasName();
    }
}