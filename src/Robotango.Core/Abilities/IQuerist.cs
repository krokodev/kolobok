// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuerist.cs

using System;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Communicative;

namespace Robotango.Core.Abilities
{
    public interface IQuerist
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
    }
}