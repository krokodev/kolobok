// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// ISocial.cs

using System;

namespace Kolobok.Core.Types
{
    public interface ISocial {
        T Replies<T>( Func< IWorld, object > p0 );
    }
}