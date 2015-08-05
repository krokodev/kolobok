// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAgent.cs

using Robotango.Common.Domain.Types.Expressions;
using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Types.Agency
{
    public interface IAgent : IIdentifiable, IResearchable, IExecutor< IAgent >
    {
        T As<T>() where T : IAbility;
        bool Is<T>() where T : IAbility;
        IAgent Clone();
        IReality Reality { get; set; }
        string Name { get; set; }
        uint Depth { get; }
        string FullName { get; }
        IExecutor< IAgent > IExecutor { get; }
        bool HasName();
    }
}