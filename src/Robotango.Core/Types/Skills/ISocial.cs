// Robotango (c) 2015 Krokodev
// Robotango.Core
// ISocial.cs

using System;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Communications;

namespace Robotango.Core.Types.Skills
{
    public interface ISocial
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}