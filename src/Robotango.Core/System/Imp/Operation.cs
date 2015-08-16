// Robotango (c) 2015 Krokodev
// Robotango.Core
// Operation.cs

using Robotango.Common.Types.Types;
using Robotango.Common.Utils.Tools;

namespace Robotango.Core.System.Imp
{
    public class Operation<T> : IOperation
    {
        #region Data

        private readonly IAgent _operand;
        private readonly IActivity _activity;
        private readonly T _arg;
        private readonly string _name;

        #endregion


        #region Ctor

        public Operation( IActivity activity, IAgent operand, T arg )
        {
            _operand = operand;
            _activity = activity;
            _arg = arg;
            _name = string.Format( "{0}({1},{2})", activity.Name, operand.Name, arg );
        }

        #endregion


        #region IOperation

        void IOperation.Realize( IReality reality )
        {
            _activity.Execute( reality.GetAgent( _operand ), _arg );
        }

        IActivity IOperation.Activity
        {
            get { return _activity; }
        }

        IAgent IOperation.Operand
        {
            get { return _operand; }
        }

        object IOperation.Arg
        {
            get { return _arg; }
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line(
                level,
                "{0} <{1}>",
                _name,
                GetType().Name
                );
        }

        #endregion
    }
}