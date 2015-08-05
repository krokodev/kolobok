// Robotango (c) 2015 Krokodev
// Robotango.Core
// Accessor.cs

using System;

namespace Robotango.Core.Expressions
{
    public abstract class AgentAccessor<TBase, TInterface>
    {
        #region Ctor

        protected AgentAccessor( Func< TBase, TInterface > convertor )
        {
            Convert = convertor;
        }

        #endregion


        #region Fields

        protected readonly Func< TBase, TInterface > Convert;

        #endregion
    }
}