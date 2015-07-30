// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// BaseTests.cs

using System;
using Kolobok.Core.Factory;
using Kolobok.Core.Types;
using NUnit.Framework;

namespace Kolobok.Utils
{
    public class BaseTests
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

        protected static void Log( object arg )
        {
            Console.WriteLine( arg );
        }

        protected static void Log( string format, params object[] args )
        {
            Console.WriteLine( format, args );
        }

        #endregion
    }
}