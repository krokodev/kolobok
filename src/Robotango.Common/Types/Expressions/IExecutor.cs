// Robotango (c) 2015 Krokodev
// Robotango.Common
// IExecutor.cs

using System;

namespace Robotango.Common.Types.Expressions
{
    public interface IExecutor<out T>
    {
        IExecutor< T > Do( Action< T > action );
        TV Get<TV>( IPropertyAccessor< T, TV > propertyAccessor );
        void Set<TV>( IPropertyAccessor< T, TV > propertyAccessor, TV value );
        bool Is( Func< T, bool > predicate );
    }
}