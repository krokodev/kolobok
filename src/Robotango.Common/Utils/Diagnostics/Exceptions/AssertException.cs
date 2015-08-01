// Robotango (c) 2015 Krokodev
// Robotango.Common
// AssertException.cs

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class AssertException : AbstractException
    {
        public AssertException( string format, params object[] args )
            : base( format, args ) {}
    }
}