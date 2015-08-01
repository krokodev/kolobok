// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAgent.cs

using Robotango.Common.Types.Properties;

namespace Robotango.Core.Types.Agency
{
    public interface IAgent : IIdentifiable, IResearchable
    {
        T As<T>() where T : IAbility;
        IAgent Clone();
        IReality Reality { get; set; }
        string Name { get; set; }
        uint Depth { get; }
        string FullName { get; }
        bool HasName();
    }
}