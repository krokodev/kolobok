// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Components.cs

using NUnit.Framework;
using Robotango.Core.Diagnostics;
using Robotango.Core.Implements.Skills;
using Robotango.Core.Types.Components;
using Robotango.Core.Types.Compositions;
using Robotango.Core.Types.Skills;
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

        [Test, ExpectedException( typeof( RobotangoException ) )]
        public void Non_unique_components_cause_exception()
        {
            Factory.CreateAgent< IRational, IRational >();
        }
    }
}