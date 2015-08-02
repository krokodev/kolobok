// Robotango (c) 2015 Krokodev
// Robotango.Common
// AbstractException.cs

using System;

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public abstract class AbstractException : Exception
    {
        protected AbstractException( string format, params object[] args )
            : base( string.Format( format, args ) ) {}
    }
}