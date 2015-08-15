// Robotango (c) 2015 Krokodev
// Robotango.Core
// ExistingDesire.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;
using Robotango.Core.Common;

namespace Robotango.Core.Elements.Desirous
{
    public class ExistingDesire : Desire< INothing >, IExistingDesire
    {
        #region Ctor

        public ExistingDesire( IAgent subject )
            : base( Desires.Reality.Existing, subject ) {}

        #endregion
    }
}