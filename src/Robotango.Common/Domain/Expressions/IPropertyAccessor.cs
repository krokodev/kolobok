// Robotango (c) 2015 Krokodev
// Robotango.Common
// IPropertyAccessor.cs

using System;

namespace Robotango.Common.Domain.Expressions
{
    public interface IPropertyAccessor<in T, TV>
    {
        Func< T, TV > Get { get; }
        Action< T, TV > Set { get; }
    }
}