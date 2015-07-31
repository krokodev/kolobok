// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IEntity.cs

namespace Kolobok.Core.Types
{
    public interface IEntity
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}