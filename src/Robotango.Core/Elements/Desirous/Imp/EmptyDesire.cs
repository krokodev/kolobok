// Robotango (c) 2015 Krokodev
// Robotango.Core
// EmptyDesire.cs

using Robotango.Common.Domain.Types;
using Robotango.Core.Common;

namespace Robotango.Core.Elements.Desirous.Imp
{
    public class EmptyDesire : Desire< INothing >
    {
        #region Ctor

        public EmptyDesire()
            : base( Lib.Desires.Nothing ) {}

        #endregion
    }
}