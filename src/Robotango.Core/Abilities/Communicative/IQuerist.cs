// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuerist.cs

using System;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Communicative
{
    public interface IQuerist
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
    }
}