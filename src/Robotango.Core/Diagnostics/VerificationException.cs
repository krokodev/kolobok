// Robotango (c) 2015 Krokodev
// Robotango.Core
// VerificationException.cs

namespace Robotango.Core.Diagnostics
{
    public class VerificationException : RobotangoException
    {
        public VerificationException( string format, params object[] args )
            : base( format, args ) {}
    }
}