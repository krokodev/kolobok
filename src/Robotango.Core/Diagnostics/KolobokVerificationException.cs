// Robotango (c) 2015 Krokodev
// Robotango.Core
// KolobokVerificationException.cs

namespace Robotango.Core.Diagnostics
{
    public class KolobokVerificationException : KolobokException
    {
        public KolobokVerificationException( string format, params object[] args )
            : base( format, args ) {}
    }
}