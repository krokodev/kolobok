// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IFactory.cs

using System.Collections.Generic;

namespace Kolobok.Core
{
    public interface IFactory
    {
        IAgent CreateAgent( params IComponent [] components );
        IComponent CreateComponent<T>();
    }
}