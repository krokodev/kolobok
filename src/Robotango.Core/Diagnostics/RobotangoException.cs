// Robotango (c) 2015 Krokodev
// Robotango.Core
// RobotangoException.cs

using System;

namespace Robotango.Core.Diagnostics
{
    public class RobotangoException : Exception
    {
        public RobotangoException( string format, params object[] args )
            : base( string.Format( format, args ) ) {}
    }
}