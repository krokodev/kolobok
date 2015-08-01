// Robotango (c) 2015 Krokodev
// Robotango.Core
// ICommunicative.cs

using System;
using Robotango.Core.Types.Domain.Agency;
using Robotango.Core.Types.Domain.Communications;

namespace Robotango.Core.Types.Domain.Abilities
{
    public interface ICommunicative : IAbility
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}