// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IFactory.cs

namespace Kolobok.Core.Types
{
    public interface IFactory
    {
        IAgent CreateAgent<T1>(string name="");
        IAgent CreateAgent<T1, T2>(string name="");
        IAgent CreateAgent<T1, T2, T3>(string name="");
        IAgent CreateAgent<T1, T2, T3, T4>(string name="");
        IAgent CreateAgent<T1, T2, T3, T4, T5>(string name="");
        IAgent CreateAgent( params IComponent[] components );
        IAgent CreateAgent( string name, params IComponent[] components );
        IComponent CreateComponent<T>();
    }
}