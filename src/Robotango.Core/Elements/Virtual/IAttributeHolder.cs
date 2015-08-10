// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttributeHolder.cs

using System;
using System.Collections.Generic;

namespace Robotango.Core.Elements.Virtual
{
    public interface IAttributeHolder
    {
        IList< T > All<T>();
        void AddAttribute( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetAttribute<T>() where T : IAttribute;
        bool Has<T>() where T : IAttribute;
        void Set<T, TF>( Action< T, TF > setter, TF fieldValue ) where T : IAttribute, new();
    }
}