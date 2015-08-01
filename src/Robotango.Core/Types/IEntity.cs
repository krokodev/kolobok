// Robotango (c) 2015 Krokodev
// Robotango.Core
// IEntity.cs

namespace Robotango.Core.Types
{
    public interface IEntity
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}