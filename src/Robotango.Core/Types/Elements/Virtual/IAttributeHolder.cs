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
        void Set<T, TF>( Action< T, TF > setter, TF fieldValue ) where T : IAttribute, new();
    }
}