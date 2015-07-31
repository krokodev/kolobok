// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// KolobokUnknownAgentException.cs

namespace Kolobok.Core.Diagnostics
{
    internal class KolobokUnknownAgentException : KolobokException
    {
        public KolobokUnknownAgentException( string format, params object[] args )
            : base( format, args ) {}
    }
}