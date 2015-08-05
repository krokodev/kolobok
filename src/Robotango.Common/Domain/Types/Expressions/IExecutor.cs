// Robotango (c) 2015 Krokodev
// Robotango.Common
// IActionExecuter.cs

using System;

namespace Robotango.Common.Domain.Types.Expressions
{
    public interface IExecutor<T>
    {
        IExecutor< T > Do( Action< T > action );
        TV Get<TV>( IPropertyAccessor< T, TV > propertyAccessor );
        void Set<TV>( IPropertyAccessor< T, TV > propertyAccessor, TV value );
    }
}

    