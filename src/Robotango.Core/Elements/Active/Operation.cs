// Robotango (c) 2015 Krokodev
// Robotango.Core
// Operation.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public class Operation<T> : IOperation
    {
        #region Fields

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
            _name = string.Format( "{0}({1},{2})", activity.Name, operand.Name, arg);
        }

        #endregion


        #region IOperation

        void IOperation.Realize( IReality reality )
        {
            _activity.Execute( reality.GetAgent( _operand ), _arg );
        }

        public string Name { get{return _name;} }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line(
                level,
                "{0} <{1}>",
                _name,
                typeof( Operation< T > ).Name
                );
        }

        #endregion
    }
}