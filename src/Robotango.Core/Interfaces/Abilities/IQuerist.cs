// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuerist.cs

using System;
using Robotango.Core.Elements.Communicative;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Interfaces.Abilities
{
    public interface IQuerist
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
    }
}