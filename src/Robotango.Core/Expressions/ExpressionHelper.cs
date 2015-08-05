// Robotango (c) 2015 Krokodev
// Robotango.Core
// ExpressionHelper.cs

using System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public abstract class ExpressionHelper<TBase, TInterface>
    {
        #region Ctor

        protected ExpressionHelper( Func< TBase, TInterface> convertor )
        {
            ToExpressionType = convertor;
        }


        #endregion

        #region Fields
        protected readonly Func< TBase, TInterface> ToExpressionType;

        #endregion
    }
}