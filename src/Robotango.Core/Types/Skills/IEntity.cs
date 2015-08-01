// Robotango (c) 2015 Krokodev
// Robotango.Core
// IEntity.cs

using Robotango.Core.Types.Common;

namespace Robotango.Core.Types.Skills
{
    public interface IEntity
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}