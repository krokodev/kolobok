// Robotango (c) 2015 Krokodev
// Robotango.Common
// UnknownActivityException.cs

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class UnknownActivityException : AbstractException
    {
        public UnknownActivityException( string format, params object[] args )
            : base( format, args ) {}

    }
}