// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttributeHolder.cs

using System;
using System.Collections.Generic;

namespace Robotango.Core.Abilities.Virtual
{
    public interface IAttributeHolder
    {
        IList< T > All<T>();
        void AddAttribute( IAttribute attribute );
        T AddAttribute<T>() where T : IAttribute, new();
        T GetAttribute<T>() where T : IAttribute;
        bool HasAttribute<T>() where T : IAttribute;
        void SetAttributeTo<T, TF>( Action< T, TF > setter, TF fieldValue ) where T : IAttribute, new();
    }
}