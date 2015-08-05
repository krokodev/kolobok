// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttributeHolder.cs

using System;

namespace Robotango.Core.Types.Elements.Virtual
{
    public interface IAttributeHolder
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T Get<T>() where T : IAttribute;
        bool Has<T>() where T : IAttribute;
        void Set<T, TV>( Action< T, TV > setter, TV value ) where T : IAttribute, new();
    }
}