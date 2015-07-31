// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IAgent.cs

namespace Kolobok.Core.Types
{
    public interface IAgent : IIdentifiable
    {
        T As<T>();
        IAgent Clone();
        IWorld World { get; set; }
        string Name { get; set; }
    }
}