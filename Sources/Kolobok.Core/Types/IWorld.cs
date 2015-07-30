// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IWorld.cs

namespace Kolobok.Core.Types
{
    public interface IWorld: IIdentifiable {
        IAgent Agent( IAgent agent );
        void Contains( params IAgent[] agents);
        IWorld Clone();
    }
}