// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Activities.cs

using NUnit.Framework;
using Robotango.Core.Implements.Domain.Virtuals;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Domain.Virtuals;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Complex
{
    [TestFixture]
    public class Activities : BaseTests
    {
        [Test]
        public void Agent_can_move()
        {
            var world = Factory.CreateWorld( "The World" );
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );
            var locA = new Location( "A" );
            var locB = new Location( "B" );

            world.Reality.Add( alice );

            alice.As< IVirtual >().Add( new Position( locA ) );

            Assert.Ignore();
        }

        [Test]
        public void Agent_has_Alive_attribute()
        {
            Assert.Ignore();
        }

        [Test]
        public void Reaity_can_kiil_the_agent()
        {
            Assert.Ignore();
        }

        [Test]
        public void Alice_asks_Bob_to_pass_her_throw_door()
        {
            var house = Factory.CreateReality( "The House" );
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );
            var bob = Factory.CreateAgent< IVirtual >( "Bob" );

            var initial = new Location( "Initial" );
            var destination = new Location( "Destination" );
            var reserve = new Location( "Reserve" );

            house.Add( alice, bob );
            alice.As< IVirtual >().Add( new Position( initial ) );
            bob.As< IVirtual >().Add( new Position( destination ) );

            Log( house.Dump() );

            Assert.AreEqual( "Destination", destination.ILocation.Name );
            Assert.AreEqual( initial, alice.As< IVirtual >().GetFirst< IPosition >().Location );

            Assert.Ignore();
        }
    }
}