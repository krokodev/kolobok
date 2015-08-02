// Robotango (c) 2015 Krokodev
// Robotango.Tests
// BaseTests.cs

using System;
using NUnit.Framework;
using Robotango.Core.System;

namespace Robotango.Tests.Utils.Bases
{
    public abstract class BaseTests
    {
        #region Init

        [SetUp]
        public void Init()
        {
            Factory = new Factory();
        }

        #endregion


        #region Protected Utils

        protected IFactory Factory { get; set; }

        protected static void Log( string str )
        {
            Console.WriteLine( str );
        }

        protected static void Log( object obj )
        {
            Console.WriteLine( obj.ToString() );
        }

        protected static void Log( string format, params object[] args )
        {
            Console.WriteLine( format, args );
        }

        #endregion
    }
}