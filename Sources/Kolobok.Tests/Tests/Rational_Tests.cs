// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Rational_Tests.cs

using Kolobok.Asserts;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Rational_Tests : CoreBaseTests
    {
        [Test]
        public void Rational_can_think()
        {
            var a = Factory.CreateAgent< IRational >();
            RationalsAssertThat.Rational_can_think( a );
        }
    }
}