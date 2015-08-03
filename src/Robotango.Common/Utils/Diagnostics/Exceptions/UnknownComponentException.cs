// Robotango (c) 2015 Krokodev
// Robotango.Common
// UnknownComponentException.cs

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class UnknownComponentException : AbstractException
    {
        public UnknownComponentException( string format, params object[] args )
            : base( format, args ) {}
    }
}