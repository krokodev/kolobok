// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Components_Tests.cs

using Kolobok.Asserts;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Implementations;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Components_Tests : BaseTests
    {
        [Test]
        public void Rational_is_a_component()
        {
            IRational r = new Rational();
            ComponentsAssertThat.Is_component( r );
        }

        [Test]
        public void Factory_creates_composite_agent()
        {
            var r = Factory.CreateComponent< IRational >();
            var s = Factory.CreateComponent< ISocial >();
            var a = Factory.CreateAgent( r, s );
            ComponentsAssertThat.Has_rational_and_social_components( a as IComposition );
        }

        [Test]
        public void Factory_conveniently_creates_composite_agent()
        {
            var a = Factory.CreateAgent< IRational, ISocial >();
            ComponentsAssertThat.Has_rational_and_social_components( a as IComposition );
        }

        [Test, ExpectedException( typeof( KolobokException ) )]
        public void Non_unique_components_cause_exception()
        {
            Factory.CreateAgent< IRational, IRational >();
        }
    }
}