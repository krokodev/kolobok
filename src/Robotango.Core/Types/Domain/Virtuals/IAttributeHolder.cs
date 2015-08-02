// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttributeHolder.cs

namespace Robotango.Core.Types.Domain.Virtuals
{
    public interface IAttributeHolder
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>() where T : IAttribute;
    }
}