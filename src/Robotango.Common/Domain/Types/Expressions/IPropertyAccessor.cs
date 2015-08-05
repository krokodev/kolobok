// Robotango (c) 2015 Krokodev
// Robotango.Common
// IPropertyAccessor.cs

using System;

namespace Robotango.Common.Domain.Types.Expressions
{
    public interface IPropertyAccessor<T, TV> {
        Func< T, TV > Get { get; }
    }
}