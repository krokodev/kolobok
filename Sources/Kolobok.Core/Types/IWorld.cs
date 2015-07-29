// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IWorld.cs

namespace Kolobok.Core.Types
{
    public interface IWorld {
        IAgent Agent( IAgent a );
        void Add( params IAgent[] agents);
    }
}