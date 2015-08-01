// Robotango (c) 2015 Krokodev
// Robotango.Common
// VerificationException.cs

namespace Robotango.Common.Implements.Diagnostics
{
    public class VerificationException : RobotangoException
    {
        public VerificationException( string format, params object[] args )
            : base( format, args ) {}
    }
}