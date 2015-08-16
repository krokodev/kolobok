// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Virtual_Tests.cs

using NUnit.Framework;
using Robotango.Common.Types.Enums;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Abilities;
using Robotango.Core.Abilities.Virtual;
using Robotango.Core.Abilities.Virtual.Imp;
using Robotango.Expressions.Terms;
using Robotango.Tests.Base;
using Robotango.Tests.Stuff;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Virtual_Tests : BaseTests
    {
        [Test, ExpectedException( typeof( AssertException ) )]
        public void Entety_cant_have_others_attribute()
        {
            var alice = Factory.CreateAgent< IVirtual >().As< IVirtual >();
            var bob = Factory.CreateAgent< IVirtual >().As< IVirtual >();
            var hat = new Hat();

            alice.AddAttribute( hat );
            bob.AddAttribute( hat );
        }

        [Test]
        public void Cloned_agent_has_the_same_attribute_value()
        {
            var alice = Factory.CreateAgent< IVirtual >();
            alice.As< IVirtual >().AddAttribute< Hat >().IHat.Color = Colors.Red;
            var clone = alice.Clone();

            IHat aHat = alice.As< IVirtual >().GetAttribute< Hat >();
            IHat cHat = clone.As< IVirtual >().GetAttribute< Hat >();

            Assert.AreEqual( aHat.Color, cHat.Color );
        }

        [Test]
        public void Cloned_enteties_have_different_attributes()
        {
            var agent = Factory.CreateAgent< IVirtual >();
            agent.As< IVirtual >().AddAttribute( new Hat() );
            var clone = agent.Clone();
            var aHat = agent.As< IVirtual >().GetAttribute< Hat >();
            var cHat = clone.As< IVirtual >().GetAttribute< Hat >();
            Assert.AreSame( aHat, aHat );
            Assert.AreSame( cHat, cHat );
            Assert.AreNotSame( aHat, cHat );
        }

        [Test]
        public void Alice_and_Bob_have_positions()
        {
            var house = Factory.CreateReality( "The House" );
            var alice = house.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var bob = house.AddAgent( Factory.CreateAgent< IVirtual >( "Bob" ) );

            var initial = new Location( "Initial" );
            var destination = new Location( "Destination" );

            alice.As< IVirtual >().AddAttribute( new Position( initial ) );
            bob.As< IVirtual >().AddAttribute( new Position( destination ) );

            var dump = house.Dump();

            Log( house.Dump() );

            Assert.That( dump.Contains( "Position" ) );
            Assert.That( dump.Contains( "Location" ) );
            Assert.That( dump.Contains( "Destination" ) );
            Assert.That( dump.Contains( "Initial" ) );
            Assert.AreEqual( "Destination", destination.ILocation.Name );
            Assert.AreEqual( initial, alice.As< IVirtual >().GetAttribute< IPosition >().Location );
            Assert.AreEqual( destination, bob.As< IVirtual >().GetAttribute< IPosition >().Location );
        }

        [Test]
        public void Position_location_name_should_be_cloned()
        {
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );

            var a = new Location( "A" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            var clone = alice.Clone();

            Assert.AreEqual( "A", clone.As< IVirtual >().GetAttribute< IPosition >().Location.Name );

            Log( clone.Dump() );
        }

        [Test]
        public void Agent_has_only_one_position_after_changings_locations()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );

            alice.Set( Its.Virtual.Location, new Location( "A" ) );
            alice.Set( Its.Virtual.Location, new Location( "B" ) );
            alice.Set( Its.Virtual.Location, new Location( "C" ) );

            alice.Get( Its.Virtual.Position ).Location = new Location( "D" );

            Log( world.Dump() );

            Assert.That( alice.As< IVirtual >().All< IPosition >().Count, Is.EqualTo( 1 ) );
        }

        [Test]
        public void Agent_has_many_positions_after_setting_new_positions()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );

            alice.Set( Its.Virtual.Position, new Position( new Location( "A" ) ) );
            alice.Set( Its.Virtual.Position, new Position( new Location( "B" ) ) );
            alice.Set( Its.Virtual.Position, new Position( new Location( "C" ) ) );
            alice.Set( Its.Virtual.Position, new Position( new Location( "D" ) ) );

            Log( world.Dump() );

            Assert.That( alice.As< IVirtual >().All< IPosition >().Count, Is.EqualTo( 4 ) );
        }

        [Test]
        public void Default_position_is_the_first_added()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );

            alice.Set( Its.Virtual.Position, new Position( new Location( "A" ) ) );
            alice.Set( Its.Virtual.Position, new Position( new Location( "B" ) ) );
            alice.Set( Its.Virtual.Position, new Position( new Location( "C" ) ) );
            alice.Set( Its.Virtual.Position, new Position( new Location( "D" ) ) );

            Log( world.Dump() );

            Assert.That( alice.Get( Its.Virtual.Location ).Name, Is.EqualTo( "A" ) );
        }
    }
}