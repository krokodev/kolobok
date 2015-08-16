// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAgent.cs

using System;
using Robotango.Common.Types.Expressions;
using Robotango.Common.Types.Types;
using Robotango.Core.Abilities;

namespace Robotango.Core.System
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