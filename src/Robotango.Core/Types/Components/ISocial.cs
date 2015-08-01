// Robotango (c) 2015 Krokodev
// Robotango.Core
// ISocial.cs

using System;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Communications;
using Robotango.Core.Types.Compositions;

namespace Robotango.Core.Types.Components
{
    public interface ISocial: IComponent
    {
        IQuestion< T > Ask<T>( Func< IReality, T > theme );
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}