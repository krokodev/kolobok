// Robotango (c) 2015 Krokodev
// Robotango.Core
// ExistingDesire.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Agency;
using Robotango.Core.Common;

namespace Robotango.Core.Elements.Desirous.Imp
{
    public class ExistingDesire : Desire< INothing >, IExistingDesire
    {
        #region Ctor

        public ExistingDesire( IAgent subject )
            : base( Lib.Desires.Existing, subject ) {}

        #endregion
    }
}