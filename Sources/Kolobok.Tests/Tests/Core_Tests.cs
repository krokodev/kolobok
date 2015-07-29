// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Core_Tests.cs

using Kolobok.Core;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Core_Tests
    {
        [Test]
        public void Rational_can_think()
        {
            IRational r = new Rational();
            r.Think();
        }

        [Test]
        public void Rational_is_a_component()
        {
            IRational r = new Rational();
            Assert.IsInstanceOf< IComponent >( r );
        }

        [Test]
        public void Factory_creates_composite_agent()
        {
            IFactory factory = new Factory();
            var r = factory.CreateComponent< IRational >();
            var s = factory.CreateComponent< ISocial >();
            var a = factory.CreateAgent( r, s );
        }

        [Test]
        public void Factory_creates_composite_agent_in_convenient_manner()
        {
            IFactory factory = new Factory();

            //            var a = factory.CreateAgent<IRational,ISocial>();
        }

        [Test]
        public void Agent_has_several_components() {}
    }
}