// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// KolobokVerificationException.cs

namespace Kolobok.Core.Diagnostics
{
    public class KolobokVerificationException : KolobokException
    {
        public KolobokVerificationException( string format, params object[] args )
            : base( format, args ) {}
    }
}