// Robotango (c) 2015 Krokodev
// Robotango.Common
// RobotangoException.cs

using System;

namespace Robotango.Common.Implements.Diagnostics
{
    public class RobotangoException : Exception
    {
        public RobotangoException( string format, params object[] args )
            : base( string.Format( format, args ) ) {}
    }
}