// Robotango (c) 2015 Krokodev
// Robotango.Common
// PropertyAccessor.cs

using System;
using Robotango.Common.Domain.Types.Expressions;

namespace Robotango.Common.Domain.Implements.Expressions
{
    public class PropertyAccessor<T, TV> : IPropertyAccessor<T, TV>
    {
        public Func< T, TV > Get { get; set; }
    }
}