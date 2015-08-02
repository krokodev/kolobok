// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Attributes.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Implements.Domain.Virtuals;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Domain.Virtuals;
using Robotango.Tests.Domain;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Attributes : BaseTests
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
            alice.As< IVirtual >().Add< Hat >().IHat.Color = Colors.Red;
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

        [Test]
        public void Alice_and_Bob_have_positions()
        {
            var house = Factory.CreateReality( "The House" );
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );
            var bob = Factory.CreateAgent< IVirtual >( "Bob" );

            var initial = new Location( "Initial" );
            var destination = new Location( "Destination" );

            house.Add( alice, bob );
            alice.As< IVirtual >().Add( new Position( initial ) );
            bob.As< IVirtual >().Add( new Position( destination ) );

            var dump = house.Dump();

            Log( house.Dump() );

            Assert.That( dump.Contains( "Position" ) );
            Assert.That( dump.Contains( "Location" ) );
            Assert.That( dump.Contains( "Destination" ) );
            Assert.That( dump.Contains( "Initial" ) );
            Assert.AreEqual( "Destination", destination.ILocation.Name );
            Assert.AreEqual( initial, alice.As< IVirtual >().GetFirst< IPosition >().Location );
            Assert.AreEqual( destination, bob.As< IVirtual >().GetFirst< IPosition >().Location );
        }
    }
}