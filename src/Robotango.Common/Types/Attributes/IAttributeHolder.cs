// Robotango (c) 2015 Krokodev
// Robotango.Common
// IAttributeHolder.cs

namespace Robotango.Common.Types.Attributes
{
    public interface IAttributeHolder
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}