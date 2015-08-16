// Robotango (c) 2015 Krokodev
// Robotango.Common
// Debug.cs

using System;
using System.Diagnostics;
using Robotango.Common.Utils.Diagnostics.Exceptions;

namespace Robotango.Common.Utils.Diagnostics.Debug
{
    public static class Debug
    {
        public class Assert
        {
            public static void That( bool cond, string comment = "", params object[] args )
            {
                That( cond, new AssertException( comment, args ) );
            }

            public static void That( bool cond, Exception exception )
            {
                if( cond ) {
                    return;
                }
                Log( exception );
                throw exception;
            }
        }

        public static void Log( object obj )
        {
            Trace.WriteLine( obj.ToString() );
        }
    }
}