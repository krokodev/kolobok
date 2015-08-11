// Robotango (c) 2015 Krokodev
// Robotango.Core
// IReality.cs

using System.Collections.Generic;
using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Interfaces.Agency
{
    public interface IReality : IIdentifiable, IVerifiable, IResearchable
    {
        IAgent GetAgent( IAgent agent );
        IAgent AddAgent( IAgent agent );
        IReality Clone( IAgent holder = null );
        bool Contains( IAgent agent );
        void Clear();
        string Name { get; }
        IList< IAgent > Agents { get; }
    }
}