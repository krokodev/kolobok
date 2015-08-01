// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAgent.cs

namespace Robotango.Core.Types
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