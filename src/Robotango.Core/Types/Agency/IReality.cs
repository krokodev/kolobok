// Robotango (c) 2015 Krokodev
// Robotango.Core
// IReality.cs

using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Types.Agency
{
    public interface IReality : IIdentifiable, IVerifiable, IResearchable
    {
        IAgent Agent( IAgent agent );
        void Add( params IAgent[] agents );
        IReality Clone( IAgent holder = null );
        bool Contains( IAgent agent );
        void Clear();
        uint Depth { get; }
        string Name { get; }
        string FullName { get; }
        string FamilyName { get; }
        IAgent Holder { get; }
        IReality Superior { get; }
        IAgent Project( IAgent agent );
    }
}