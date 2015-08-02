// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttributeHolder.cs

namespace Robotango.Core.Types.Domain.Attributes
{
    public interface IAttributeHolder
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}