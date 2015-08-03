// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuerist.cs

using System;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Communicative;

namespace Robotango.Core.Types.Abilities
{
    public interface IQuerist
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
    }
}