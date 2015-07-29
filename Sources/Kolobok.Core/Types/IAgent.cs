// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IAgent.cs

using System;

namespace Kolobok.Core.Types
{
    public interface IAgent
    {
        T GetComponent<T>();
        T As<T>();
        IAgent Clone();
        Guid Id { get; }
    }
}