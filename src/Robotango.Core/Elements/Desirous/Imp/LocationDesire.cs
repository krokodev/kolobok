// Robotango (c) 2015 Krokodev
// Robotango.Core
// LocationDesire.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;
using Robotango.Core.Common;

namespace Robotango.Core.Elements.Desirous.Imp
{
    public class LocationDesire : Desire< ILocation >, ILocationDesire
    {
        #region Ctor

        public LocationDesire( IAgent subject, ILocation location )
            : base( Lib.Desires.Location, subject, location ) {}

        #endregion
    }
}