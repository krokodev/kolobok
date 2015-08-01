// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuerist.cs

using System;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Types.Domain.Communications
{
    public interface IQuerist
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
        
    }
}