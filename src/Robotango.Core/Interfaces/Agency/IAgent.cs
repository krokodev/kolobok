// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAgent.cs

using Robotango.Common.Domain.Types.Expressions;
using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Interfaces.Agency
{
    public interface IAgent : IIdentifiable, IResearchable, IExecutor< IAgent >, IProceedable
    {
        T As<T>() where T : IAbility;
        bool Is<T>() where T : IAbility;
        IAgent Clone();
        string Name { get; set; }
        IExecutor< IAgent > IExecutor { get; }
        bool HasName();
    }
}