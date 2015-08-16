// Robotango (c) 2015 Krokodev
// Robotango.Core
// EmptyDesire.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Common;

namespace Robotango.Core.Abilities.Desirous.Imp
{
    public class EmptyDesire : Desire< INothing >
    {
        #region Ctor

        public EmptyDesire()
            : base( Lib.Desires.Nothing ) {}

        #endregion
    }
}