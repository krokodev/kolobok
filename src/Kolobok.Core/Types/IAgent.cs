// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IAgent.cs

namespace Kolobok.Core.Types
{
    public interface IAgent : IIdentifiable
    {
        T As<T>();
        IAgent Clone();
        IWorld Reality { get; set; }
        string Name { get; set; }
        uint GetDepth();
        string GetFullName();
        bool HasName();
    }
}