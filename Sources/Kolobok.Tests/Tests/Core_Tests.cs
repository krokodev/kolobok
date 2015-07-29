// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Core_Tests.cs

using Kolobok.Base;
using Kolobok.Core.Items;
using Kolobok.Core.Types;
using Kolobok.Core.Utils;
using Kolobok.Utils;
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
            AssertThat.Is_component( r );
        }

        [Test]
        public void Factory_creates_composite_agent()
        {
            var r = Factory.CreateComponent< IRational >();
            var s = Factory.CreateComponent< ISocial >();
            var a = Factory.CreateAgent( r, s );
            AssertThat.Has_rational_and_social_components( a );
        }

        [Test]
        public void Factory_conveniently_creates_composite_agent()
        {
            var a = Factory.CreateAgent< IRational, ISocial >();
            AssertThat.Has_rational_and_social_components( a );
        }

        [Test]
        public void Non_unique_components_cause_exception()
        {
            var catched = false;
            try {
                Factory.CreateAgent< IRational, IRational >();
            }
            catch( KolobokException ) {
                catched = true;
            }
            Assert.That( catched );
        }

        [Test]
        public void Agent_has_several_components() {}
    }
}