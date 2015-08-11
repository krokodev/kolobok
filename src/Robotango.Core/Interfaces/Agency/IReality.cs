// Robotango (c) 2015 Krokodev
// Robotango.Core
// IReality.cs

using System;
using System.Collections.Generic;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;

namespace Robotango.Core.Interfaces.Agency
{
    public interface IReality : IResearchable
    {
        IAgent GetAgent( IAgent agent );
        IAgent AddAgent( IAgent agent, string name = null );
        IReality Clone();
        bool Contains( IAgent agent );
        Guid Id { get; }
        string Name { get; }
        IEnumerable< IAgent > Agents { get; }
        void AddOperation( IOperation operation );
        void Proceed();
    }
}