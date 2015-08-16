// Robotango (c) 2015 Krokodev
// Robotango.Core
// LocationDesire.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Common;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Desirous.Imp
{
    public class LocationDesire : Desire< ILocation >, ILocationDesire
    {
        #region Ctor

        public LocationDesire( IAgent subject, ILocation location )
            : base( Lib.Desires.Location, subject, location ) {}

        #endregion
    }
}