// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IWorld.cs

namespace Kolobok.Core.Types
{
    public interface IWorld : IAspect, IIdentifiable, IResearchable
    {
        IAgent Agent( IAgent agent );
        void Add( params IAgent[] agents );
        IWorld Clone();
        bool Contains( IAgent agent );
    }
}