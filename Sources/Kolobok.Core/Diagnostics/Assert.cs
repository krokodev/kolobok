// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Assert.cs

namespace Kolobok.Core.Diagnostics
{
    internal class Assert
    {
        public static void That( bool cond, string comment = "", params object[] args )
        {
            if( !cond ) {
                throw new KolobokException( comment, args );
            }
        }
    }
}