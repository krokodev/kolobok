// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Components.cs

using NUnit.Framework;
using Robotango.Common.Implements.Diagnostics;
using Robotango.Common.Types.Compositions;
using Robotango.Core.Domain.Abilities;
using Robotango.Core.Types.Domain.Abilities;
using Robotango.Tests.Helpers;
using Robotango.Tests.Utils;

namespace Robotango.Tests.Cases
{
    [TestFixture]
    public class Components : BaseCase
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
            var s = Factory.CreateComponent< ICommunicative >();
            var a = Factory.CreateAgent( r, s );
            ComponentsAssertThat.Has_rational_and_social_components( a as IComposite );
        }

        [Test]
        public void Factory_conveniently_creates_composite_agent()
        {
            var a = Factory.CreateAgent< IRational, ICommunicative >();
            ComponentsAssertThat.Has_rational_and_social_components( a as IComposite );
        }

        [Test, ExpectedException( typeof( RobotangoException ) )]
        public void Non_unique_components_cause_exception()
        {
            Factory.CreateAgent< IRational, IRational >();
        }
    }
}