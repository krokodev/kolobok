// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Activities.cs

using System.Collections.Generic;
using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
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
        public void Alice_can_move_in_her_world()
        {
            var world = Factory.CreateWorld( "The World" );
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );
            var move = new Dictionary< ILocation, ILocation > {
                { a, b },
                { b, c },
                { c, a }
            };
            alice.As< IVirtual >().Add( new Position( a ) );


            // world[alice].As<IVirtual>
            // world.Get<IVirtual>(alice).Its<Position>()[0].Location=b
            // IAgent:  IPlural/ISingle Introduce(): assert contain or not whether single or not, excpeti if neither S nor P

            world.Rational.Believes( reality => {
                var alicePosition = reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >();
                alicePosition.Location = move[ alicePosition.Location ];
            } );

            Log( world.Dump() );
            Assert.True( world.Reality.Contains( alice ) );
            Assert.AreEqual( a, world.Reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location );

            world.Rational.Think();
            Log( world.Dump() );
            Assert.AreEqual( b, world.Reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location );

            world.Rational.Think();
            Log( world.Dump() );
            Assert.AreEqual( c, world.Reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location );

            world.Rational.Think();
            Log( world.Dump() );
            Assert.AreEqual( a, world.Reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location );
        }

        [Test]
        public void Agent_has_Alive_attribute()
        {
            Assert.Ignore();
        }

        [Test]
        public void Reality_can_kiil_the_agent()
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

            house.Introduce( alice );
            house.Introduce( bob );
            alice.As< IVirtual >().Add( new Position( initial ) );
            bob.As< IVirtual >().Add( new Position( destination ) );

            Log( house.Dump() );

            Assert.AreEqual( "Destination", destination.ILocation.Name );
            Assert.AreEqual( initial, alice.As< IVirtual >().GetFirst< IPosition >().Location );

            Assert.Ignore();
        }
    }
}