// Robotango (c) 2015 Krokodev
// Robotango.Tests
// BaseTests.cs

using System;
using NUnit.Framework;
using Robotango.Core.System;

namespace Robotango.Tests.Base
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

        protected static string Log( string str )
        {
            Console.WriteLine( str );
            return str;
        }

        protected static string Log( object obj )
        {
            var str = obj.ToString();
            Console.WriteLine( str );
            return str;
        }

        protected static string Log( string template, params object[] args )
        {
            var str = string.Format( template, args );
            Console.WriteLine( str );
            return str;
        }

        #endregion
    }
}