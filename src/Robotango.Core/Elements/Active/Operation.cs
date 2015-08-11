// Robotango (c) 2015 Krokodev
// Robotango.Core
// Operation.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public class Operation<TArg> : IOperation
    {
        #region Fields

        private readonly IAgent _operand;
        private readonly Action< IAgent, TArg > _action;
        private readonly TArg _arg;

        #endregion


        #region Ctor

        public Operation( Action< IAgent, TArg > action, IAgent operand, TArg arg )
        {
            _operand = operand;
            _action = action;
            _arg = arg;
        }

        #endregion


        #region IOperation

        void IOperation.Realize( IReality reality )
        {
            _action.Invoke( reality.GetAgent( _operand ), _arg );
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line(
                level,
                "{0} ( {1}, {2} ) <{3}>",
                "Some Operation", // Todo:> Use Activity Name
                _operand.Name,
                _arg,
                typeof( Operation< TArg > ).Name
                );
        }

        #endregion
    }
}