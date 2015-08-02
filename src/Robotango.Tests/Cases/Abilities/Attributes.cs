// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Attributes.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Utils.Bases;
using Robotango.Tests.Utils.Stuff;

namespace Robotango.Tests.Cases
{
    [TestFixture]
    public class Attributes : Utils.Bases.BaseTests
    {
        [Test, ExpectedException( typeof( AssertException ) )]
        public void Entety_cant_have_others_attribute()
        {
            var alice = Factory.CreateAgent< IVirtual >().As< IVirtual >();
            var bob = Factory.CreateAgent< IVirtual >().As< IVirtual >();
            var hat = new Hat();

            alice.Add( hat );
            bob.Add( hat );
        }

        [Test]
        public void Cloned_agent_has_the_same_attribute_value()
        {
            var alice = Factory.CreateAgent< IVirtual >();
            alice.As< IVirtual >().Add<Hat>().IHat.Color = Colors.Red;
            var clone = alice.Clone();

            IHat aHat = alice.As< IVirtual >().GetFirst< Hat >();
            IHat cHat = clone.As< IVirtual >().GetFirst< Hat >();

            Assert.AreEqual( aHat.Color, cHat.Color );
        }

        [Test]
        public void Cloned_enteties_have_different_attributes()
        {
            var agent = Factory.CreateAgent< IVirtual >();
            agent.As< IVirtual >().Add( new Hat() );
            var clone = agent.Clone();
            var aHat = agent.As< IVirtual >().GetFirst< Hat >();
            var cHat = clone.As< IVirtual >().GetFirst< Hat >();
            Assert.AreSame( aHat, aHat );
            Assert.AreSame( cHat, cHat );
            Assert.AreNotSame( aHat, cHat );
        }
    }
}