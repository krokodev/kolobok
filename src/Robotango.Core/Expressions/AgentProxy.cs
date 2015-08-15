// Robotango (c) 2015 Krokodev
// Robotango.Core
// AgentProxy.cs

using System;
using Robotango.Core.Agency;

namespace Robotango.Core.Expressions
{
    public abstract class AgentProxy<T>
    {
        #region Ctor

        protected AgentProxy( Func< IAgent, T > convertor )
        {
            Convert = convertor;
        }

        #endregion


        #region Data

        protected readonly Func< IAgent, T > Convert;

        #endregion
    }
}