// Robotango (c) 2015 Krokodev
// Robotango.Core
// Intention.cs

using Robotango.Core.System;
using Robotango.Core.System.Imp;

namespace Robotango.Core.Abilities.Active.Imp
{
    public class Intention<T> : Operation< T >, IIntention
    {
        #region Ctor

        public Intention( IActivity activity, IAgent operand, T arg )
            : base( activity, operand, arg ) {}

        #endregion
    }
}