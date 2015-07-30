// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// ISocial.cs

using System;

namespace Kolobok.Core.Types
{
    public interface ISocial
    {
        IQuestion< T > Ask<T>( Func< IWorld, T > theme );
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}