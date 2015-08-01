// Robotango (c) 2015 Krokodev
// Robotango.Core
// KolobokException.cs

using System;

namespace Robotango.Core.Diagnostics
{
    public class KolobokException : Exception
    {
        public KolobokException( string format, params object[] args )
            : base( string.Format( format, args ) ) {}
    }
}