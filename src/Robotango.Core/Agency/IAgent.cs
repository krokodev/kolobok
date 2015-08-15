// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAgent.cs

using System;
using Robotango.Common.Domain.Types.Expressions;
using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Agency
{
    public interface IAgent : IResearchable, IExecutor< IAgent >, IProceedable< IReality >
    {
        T As<T>() where T : IAbility;
        bool Is<T>() where T : IAbility;
        IAgent Clone();
        string Name { get; set; }
        Guid Id { get; }
    }
}