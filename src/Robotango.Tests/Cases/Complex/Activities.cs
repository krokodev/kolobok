﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Activities.cs

using System.Collections.Generic;
using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Complex
{
    [TestFixture]
    public class Activities : BaseTests
    {
        [Test]
        public void Alice_can_move_in_her_outer_world()
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

            world.Thinking.AddBelief( reality => {
                var alicePosition = reality.Agent( alice ).As< IVirtual >().Get< IPosition >();
                alicePosition.Location = move[ alicePosition.Location ];
            } );

            Log( world.Dump() );
            Assert.True( world.Reality.Contains( alice ) );
            Assert.AreEqual( a, world.Reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location );

            world.Thinking.Think();
            Log( world.Dump() );
            Assert.AreEqual( b, world.Reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location );

            world.Thinking.Think();
            Log( world.Dump() );
            Assert.AreEqual( c, world.Reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location );

            world.Thinking.Think();
            Log( world.Dump() );
            Assert.AreEqual( a, world.Reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location );
        }

        [Test]
        public void Agent_has_Alive_attribute()
        {
            Assert.Ignore();
        }

        [Test]
        public void Reality_can_kill_the_agent()
        {
            Assert.Ignore();
        }

        [Ignore, Test]
        public void Alice_asks_Bob_to_pass_her_throw_door()
        {
            var world = Factory.CreateWorld( "The House" );
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var bob = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Bob" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );

            alice.As< IVirtual >().Add( new Position( a ) );
            alice.As< IPurposeful >().AddDesire( reality => reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location == b );
            bob.As< IVirtual >().Add( new Position( b ) );

            Log( world.Dump() );

            Assert.AreEqual( a, alice.As< IVirtual >().Get< IPosition >().Location );
            Assert.AreEqual( b, bob.As< IVirtual >().Get< IPosition >().Location );

            world.Thinking.Think();
            world.Thinking.Think();
            world.Thinking.Think();
            world.Thinking.Think();

            Log( world.Dump() );

            Assert.AreEqual( b, alice.As< IVirtual >().Get< IPosition >().Location );
            Assert.AreEqual( c, bob.As< IVirtual >().Get< IPosition >().Location );

            Assert.Ignore();
        }

        [Ignore, Test]
        public void Alice_goes_throw_the_door()
        {
            var world = Factory.CreateWorld( "The House" );
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual, IPurposeful >( "Alice" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().Add( new Position( a ) );
            alice.As< IPurposeful >().AddDesire( reality => reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location == b );

            Log( world.Dump() );

            Assert.AreEqual( a, alice.As< IVirtual >().Get< IPosition >().Location );

            world.Thinking.Think();
            world.Thinking.Think();
            world.Thinking.Think();
            world.Thinking.Think();

            Log( world.Dump() );

            Assert.AreEqual( b, alice.As< IVirtual >().Get< IPosition >().Location );

            Assert.Ignore();
        }
    }
}