// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IWorld.cs

namespace Kolobok.Core.Types
{
    public interface IWorld : IAspect, IIdentifiable, IResearchable
    {
        IAgent Agent( IAgent agent );
        void Add( params IAgent[] agents );
        IWorld Clone( IAgent holder = null );
        bool Contains( IAgent agent );
        void Clear();
        uint Depth { get; }
        string Name { get; }
        string FullName { get; }
        string FamilyName { get; }
        IAgent Holder { get; }
        IWorld Superior { get; }
    }
}