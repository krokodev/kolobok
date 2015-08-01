// Robotango (c) 2015 Krokodev
// Robotango.Common
// UnknownAgentException.cs

namespace Robotango.Common.Implements.Diagnostics
{
    public class UnknownAgentException : RobotangoException
    {
        public UnknownAgentException( string format, params object[] args )
            : base( format, args ) {}
    }
}