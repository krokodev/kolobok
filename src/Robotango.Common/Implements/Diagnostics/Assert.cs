// Robotango (c) 2015 Krokodev
// Robotango.Common
// Assert.cs

using System.Diagnostics;

namespace Robotango.Common.Implements.Diagnostics
{
    public static class Debug
    {
        public class Assert
        {
            public static void That( bool cond, string comment = "", params object[] args )
            {
                if( !cond ) {
                    Log( comment, args );
                    throw new RobotangoException( comment, args );
                }
            }
        }

        public static void Log( object obj )
        {
            Trace.WriteLine( obj.ToString() );
        }

        public static void Log( string str )
        {
            Trace.WriteLine( str );
        }

        public static void Log( string template, object[] args )
        {
            Trace.WriteLine( string.Format( template, args ) );
        }
    }
}