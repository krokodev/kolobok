// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Core_Tests.cs

using Kolobok.Core;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Core_Tests : CoreBaseTests
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
            var r = Factory.CreateComponent< IRational >();
            var s = Factory.CreateComponent< ISocial >();
            var a = Factory.CreateAgent( r, s );
            Assert.IsNotNull( a.GetComponent< IRational >() );
            Assert.IsNotNull( a.GetComponent< ISocial >() );
        }

        [Test]
        public void Non_unique_components_cause_exception()
        {
            var catched = false;
            try {
                Factory.CreateAgent(
                    Factory.CreateComponent< IRational >(),
                    Factory.CreateComponent< IRational >()
                    );
            }
            catch( KolobokException e ) {
                catched = true;
            }
            Assert.That( catched );
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