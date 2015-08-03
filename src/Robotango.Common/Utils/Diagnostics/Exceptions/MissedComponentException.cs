// Robotango (c) 2015 Krokodev
// Robotango.Common
// MissedComponentException.cs

using System;

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class MissedComponentException : AbstractException
    {
        public MissedComponentException( string format, params object[] args )
            : base( format, args ) {}

        public MissedComponentException( Type type )
            : this( "Missed component: <{0}>", type.Name ) {}
    }
}