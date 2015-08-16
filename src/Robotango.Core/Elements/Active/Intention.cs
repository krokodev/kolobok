// Robotango (c) 2015 Krokodev
// Robotango.Core
// Intention.cs

using Robotango.Core.Agency;
using Robotango.Core.Elements.Reality;
using Robotango.Core.Elements.Reality.Imp;

namespace Robotango.Core.Elements.Active
{
    public class Intention<T> : Operation< T >, IIntention
    {
        #region Ctor

        public Intention( IActivity activity, IAgent operand, T arg )
            : base( activity, operand, arg ) {}

        #endregion
    }
}