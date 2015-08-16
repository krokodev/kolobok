// Robotango (c) 2015 Krokodev
// Robotango.Common
// PropertyAccessor.cs

using System;

namespace Robotango.Common.Domain.Expressions
{
    public class PropertyAccessor<T, TV> : IPropertyAccessor< T, TV >
    {
        #region IPropertyAccessor

        Func< T, TV > IPropertyAccessor< T, TV >.Get
        {
            get { return _getter; }
        }

        Action< T, TV > IPropertyAccessor< T, TV >.Set
        {
            get { return _setter; }
        }

        #endregion


        #region Ctor

        public PropertyAccessor( Func< T, TV > getter, Action< T, TV > setter )
        {
            _getter = getter;
            _setter = setter;
        }

        #endregion


        #region Data

        private readonly Func< T, TV > _getter;
        private readonly Action< T, TV > _setter;

        #endregion
    }
}