// Robotango (c) 2015 Krokodev
// Robotango.Common
// VerificationException.cs

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class VerificationException : AbstractException
    {
        public VerificationException( string format, params object[] args )
            : base( format, args ) {}
    }
}