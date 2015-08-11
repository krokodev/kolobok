// Robotango (c) 2015 Krokodev
// Robotango.Core
// Operation.cs

using System;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public class Operation<TArg> : IOperation
    {
        private readonly IAgent _operand;
        private readonly Action< IAgent, TArg > _action;
        private readonly TArg _arg;

        public Operation( Action< IAgent, TArg > action, IAgent operand, TArg arg )
        {
            _operand = operand;
            _action = action;
            _arg = arg;
        }

        public void Execute( IReality reality )
        {
            _action.Invoke( reality.GetAgent( _operand ), _arg );
        }
    }
}