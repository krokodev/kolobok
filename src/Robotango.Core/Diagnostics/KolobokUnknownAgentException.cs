// Robotango (c) 2015 Krokodev
// Robotango.Core
// KolobokUnknownAgentException.cs

namespace Robotango.Core.Diagnostics
{
    internal class KolobokUnknownAgentException : KolobokException
    {
        public KolobokUnknownAgentException( string format, params object[] args )
            : base( format, args ) {}
    }
}