// Robotango (c) 2015 Krokodev
// Robotango.Core
// IEntity.cs

using Robotango.Core.Types.Common;
using Robotango.Core.Types.Compositions;

namespace Robotango.Core.Types.Skills
{
    public interface IEntity : IComponent
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}