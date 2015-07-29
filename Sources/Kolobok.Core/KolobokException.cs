// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// KolobokException.cs

using System;

namespace Kolobok.Core
{
    public class KolobokException : Exception
    {
        public KolobokException( string format, params object[] args )
            : base( string.Format( format, args ) ) {}
    }
}