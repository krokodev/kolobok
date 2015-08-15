// Robotango (c) 2015 Krokodev
// Robotango.Core
// Intention.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Active;

namespace Robotango.Core.Elements.Purposeful
{
    public class Intention : IIntention
    {
        #region Data

        private readonly IOperation _operation;
        private readonly string _name;

        #endregion


        #region Ctor

        public Intention( IOperation operation )
        {
            _operation = operation;
            _name = operation.Name;
        }

        #endregion


        #region IIntention

        void IIntention.Realize( IReality reality )
        {
            _operation.Realize( reality );
        }

        IOperation IIntention.Operation
        {
            get { return _operation; }
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level,
                "{0} <{1}>",
                _name,
                typeof( Intention ).Name
                );
        }

        #endregion
    }
}