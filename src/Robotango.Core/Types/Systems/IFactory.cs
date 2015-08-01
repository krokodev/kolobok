// Robotango (c) 2015 Krokodev
// Robotango.Core
// IFactory.cs

using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Compositions;

namespace Robotango.Core.Types.Systems
{
    public interface IFactory
    {
        IAgent CreateAgent<T1>( string name = null )
            where T1 : IComponent;

        IAgent CreateAgent<T1, T2>( string name = null )
            where T1 : IComponent
            where T2 : IComponent;

        IAgent CreateAgent<T1, T2, T3>( string name = null )
            where T1 : IComponent
            where T2 : IComponent
            where T3 : IComponent;

        IAgent CreateAgent<T1, T2, T3, T4>( string name = null )
            where T1 : IComponent
            where T2 : IComponent
            where T3 : IComponent
            where T4 : IComponent;

        IAgent CreateAgent<T1, T2, T3, T4, T5>( string name = null )
            where T1 : IComponent
            where T2 : IComponent
            where T3 : IComponent
            where T4 : IComponent
            where T5 : IComponent;

        IAgent CreateAgent<T1, T2, T3, T4, T5, T6>( string name = null )
            where T1 : IComponent
            where T2 : IComponent
            where T3 : IComponent
            where T4 : IComponent
            where T5 : IComponent
            where T6 : IComponent;

        IAgent CreateAgent<T1, T2, T3, T4, T5, T6, T7>( string name = null )
            where T1 : IComponent
            where T2 : IComponent
            where T3 : IComponent
            where T4 : IComponent
            where T5 : IComponent
            where T6 : IComponent
            where T7 : IComponent;

        IAgent CreateAgent( params IComponent[] components );
        IAgent CreateAgent( string name, params IComponent[] components );
        IComponent CreateComponent<T>() where T : IComponent;
        IReality CreateReality( string name = null );
    }
}