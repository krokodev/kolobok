// Robotango (c) 2015 Krokodev
// Robotango.Core
// UnknownAgentException.cs

namespace Robotango.Core.Diagnostics
{
    internal class UnknownAgentException : RobotangoException
    {
        public UnknownAgentException( string format, params object[] args )
            : base( format, args ) {}
    }
}