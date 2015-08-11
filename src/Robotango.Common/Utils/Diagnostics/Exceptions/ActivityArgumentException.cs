// Robotango (c) 2015 Krokodev
// Robotango.Common
// ActivityArgumentException.cs

namespace Robotango.Common.Utils.Diagnostics.Exceptions
{
    public class ActivityArgumentException : AbstractException
    {
        public ActivityArgumentException( string format, params object[] args )
            : base( format, args ) {}
    }
}