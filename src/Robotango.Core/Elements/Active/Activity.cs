// Robotango (c) 2015 Krokodev
// Robotango.Core
// Activity.cs

using System;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public class Activity<T> : IActivity< T >
    {
        private readonly Action< IAgent, T > _action;

        public void Run( IAgent operand, T arg )
        {
            _action.Invoke( operand, arg );
        }

        public Activity( Action< IAgent, T > action )
        {
            _action = action;
        }
    }
}