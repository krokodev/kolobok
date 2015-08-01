// Robotango (c) 2015 Krokodev
// Robotango.Core
// ISocial.cs

using System;

namespace Robotango.Core.Types
{
    public interface ISocial
    {
        IQuestion< T > Ask<T>( Func< IWorld, T > theme );
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}