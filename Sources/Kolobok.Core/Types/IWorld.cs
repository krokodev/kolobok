// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IWorld.cs

using System;

namespace Kolobok.Core.Types
{
    public interface IWorld {
        IAgent Agent( IAgent agent );
        void Contains( params IAgent[] agents);
        IWorld Clone();
    }
}