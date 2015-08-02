// Robotango (c) 2015 Krokodev
// Robotango.Core
// IFactory.cs

using Robotango.Core.Types.Agency;

namespace Robotango.Core.System
{
    public interface IFactory
    {
        IAgent CreateAgent<T1>( string name = null )
            where T1 : IAbility;

        IAgent CreateAgent<T1, T2>( string name = null )
            where T1 : IAbility
            where T2 : IAbility;

        IAgent CreateAgent<T1, T2, T3>( string name = null )
            where T1 : IAbility
            where T2 : IAbility
            where T3 : IAbility;

        IAgent CreateAgent<T1, T2, T3, T4>( string name = null )
            where T1 : IAbility
            where T2 : IAbility
            where T3 : IAbility
            where T4 : IAbility;

        IAgent CreateAgent<T1, T2, T3, T4, T5>( string name = null )
            where T1 : IAbility
            where T2 : IAbility
            where T3 : IAbility
            where T4 : IAbility
            where T5 : IAbility;

        IAgent CreateAgent<T1, T2, T3, T4, T5, T6>( string name = null )
            where T1 : IAbility
            where T2 : IAbility
            where T3 : IAbility
            where T4 : IAbility
            where T5 : IAbility
            where T6 : IAbility;

        IAgent CreateAgent<T1, T2, T3, T4, T5, T6, T7>( string name = null )
            where T1 : IAbility
            where T2 : IAbility
            where T3 : IAbility
            where T4 : IAbility
            where T5 : IAbility
            where T6 : IAbility
            where T7 : IAbility;

        IAgent CreateAgent( params IAbility[] abilities );
        IAgent CreateAgent( string name, params IAbility[] abilities );
        IAbility CreateComponent<T>() where T : IAbility;
        IReality CreateReality( string name = null );
        IWorld CreateWorld( string  name = null );
    }
}