// Robotango (c) 2015 Krokodev
// Robotango.Core
// ICommunicative.cs

using System;
using Robotango.Core.Types.Communications;

namespace Robotango.Core.Types.Agency.Abilities
{
    public interface ICommunicative : IAbility, IRespondent, IQuerist
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}