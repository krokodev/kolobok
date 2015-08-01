// Robotango (c) 2015 Krokodev
// Robotango.Common
// UnknownAgentException.cs

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class UnknownAgentException : AbstractException
    {
        public UnknownAgentException( string format, params object[] args )
            : base( format, args ) {}
    }
}