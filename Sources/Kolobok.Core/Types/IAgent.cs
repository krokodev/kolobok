// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IAgent.cs

namespace Kolobok.Core.Types
{
    public interface IAgent
    {
        IComponent GetComponent<T>();
    }
}