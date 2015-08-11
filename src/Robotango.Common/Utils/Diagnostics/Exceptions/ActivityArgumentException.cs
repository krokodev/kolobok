// Robotango (c) 2015 Krokodev
// Robotango.Common
// MissedComponentException.cs

using System;

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class ActivityArgumentException : AbstractException
    {
        public ActivityArgumentException( string format, params object[] args )
            : base( format, args ) {}
    }
}