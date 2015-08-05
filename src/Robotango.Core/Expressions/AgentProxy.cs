// Robotango (c) 2015 Krokodev
// Robotango.Core
// AgentProxy.cs

using System;
using Robotango.Core.Types.Agency;

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


        #region Fields

        protected readonly Func< IAgent, T > Convert;

        #endregion
    }
}