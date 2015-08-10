// Robotango (c) 2015 Krokodev
// Robotango.Core
// Operation.cs

using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public class Operation<T> : IOperation
    {
        private readonly IAgent _actor;
        private readonly IAgent _operand;
        private readonly IActivity< T > _activity;
        private readonly T _arg;

        public Operation( IAgent actor, IActivity< T > activity, IAgent operand, T arg )
        {
            _actor = actor;
            _operand = operand;
            _activity = activity;
            _arg = arg;
        }

        public void Execute( IReality reality )
        {
            _activity.Run( reality.GetAgent( _operand ), _arg );
        }
    }
}