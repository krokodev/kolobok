﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Behavioural_Tests.cs

using System.Collections.Generic;
using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Expressions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Complex
{
    [TestFixture]
    public class Behavioural_Tests : BaseTests
    {
        [Test]
        public void Alice_can_move_in_her_outer_world()
        {
            var world = Factory.CreateWorld( "The World" );
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );
            var move = new Dictionary< ILocation, ILocation > {
                { a, b },
                { b, c },
                { c, a }
            };
            alice.As< IVirtual >().AddAttribute( new Position( a ) );

            world.IThinking.AddBelief( reality => {
                var alicePosition = reality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >();
                alicePosition.Location = move[ alicePosition.Location ];
            } );

            Log( world.Dump() );
            Assert.True( world.IReality.Contains( alice ) );
            Assert.That( world.GetAgent( alice ).Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            world.IThinking.ImplementBeliefs();
            Log( world.Dump() );
            Assert.That( world.GetAgent( alice ).Get( Its.Virtual.Location ), Is.EqualTo( b ) );

            world.IThinking.ImplementBeliefs();
            Log( world.Dump() );
            Assert.That( world.GetAgent( alice ).Get( Its.Virtual.Location ), Is.EqualTo( c ) );

            world.IThinking.ImplementBeliefs();
            Log( world.Dump() );
            Assert.That( world.GetAgent( alice ).Get( Its.Virtual.Location ), Is.EqualTo( a ) );
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
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var bob = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Bob" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IPurposeful >().AddDesire(
                reality =>
                    reality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >().Location == b
                );
            bob.As< IVirtual >().AddAttribute( new Position( b ) );

            Log( world.Dump() );

            Assert.AreEqual( a, alice.As< IVirtual >().GetAttribute< IPosition >().Location );
            Assert.AreEqual( b, bob.As< IVirtual >().GetAttribute< IPosition >().Location );

            world.IThinking.ImplementBeliefs();
            world.IThinking.ImplementBeliefs();
            world.IThinking.ImplementBeliefs();
            world.IThinking.ImplementBeliefs();

            Log( world.Dump() );

            Assert.AreEqual( b, alice.As< IVirtual >().GetAttribute< IPosition >().Location );
            Assert.AreEqual( c, bob.As< IVirtual >().GetAttribute< IPosition >().Location );

            Assert.Ignore();
        }

    }
}