﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Purposes.cs

using NUnit.Framework;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Purposes : BaseTests
    {
        [Test]
        public void Agent_can_be_Purposeful()
        {
            Factory.CreateAgent< IPurposeful, IThinking >();
        }

        [Test, ExpectedException( typeof( MissedComponentException ) )]
        public void Purposeful_agent_must_be_Thinking()
        {
            Factory.CreateAgent< IPurposeful >();
        }

        [Test]
        public void Purposeful_dump_contains_desires()
        {
            var agent = Factory.CreateAgent< IPurposeful, IThinking >();
            agent.As< IPurposeful >().AddDesire( reality => reality.Contains( agent ) == false );

            var dump = Log( agent.Dump() );

            Assert.That( dump, Is.StringContaining( "<Purposeful>" ) );
            Assert.That( dump, Is.StringContaining( "Desires" ) );
            Assert.That( dump, Is.StringContaining( "Some Desire" ) );
        }

        [Test]
        public void Desire_can_be_satisfied()
        {
            var agent = Factory.CreateAgent< IPurposeful, IThinking >();
            var desire = agent.As< IPurposeful >().AddDesire( reality => reality.Contains( agent ) );

            Log( agent.Dump() );

            Assert.False( desire.IsSatisfied() );

            agent.As< IThinking >().Imagination.Introduce( agent );

            Assert.That( desire.IsSatisfied(), Is.True );
        }

        [Test]
        public void Alice_intends_to_be_in_location_B_and_is_satisfied_by_suggestion_that_she_is()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual, IPurposeful, IThinking >( "Alice" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().Add( new Position( a ) );
            var herself = alice.As< IThinking >().Imagination.Introduce( alice );

            var desire = alice.As< IPurposeful >().AddDesire(
                reality =>
                    reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location == b
                );

            Log( world.Dump() );

            alice.As< IVirtual >().Get< IPosition >().Location = b;
            Assert.False( desire.IsSatisfied() );

            alice.As< IVirtual >().Get< IPosition >().Location = a;
            herself.As< IVirtual >().Get< IPosition >().Location = b;
            Assert.True( desire.IsSatisfied() );
        }

        [Test]
        public void Desire_can_be_named_and_names_are_dumped()
        {
            var agent = Factory.CreateAgent< IPurposeful, IThinking >();
            var a = new Location( "A" );

            agent.As< IPurposeful >().AddDesire(
                reality => true
                );
            agent.As< IPurposeful >().AddDesire(
                reality =>
                    reality.Contains( agent ),
                "Wants to be present"
                );
            agent.As< IPurposeful >().AddDesire(
                reality =>
                    reality.Agent( agent ).As< IVirtual >().Get< IPosition >().Location == a,
                "Wants to be in A"
                );

            var dump = Log( agent.Dump() );

            Assert.That( dump, Is.StringContaining( "Some Agent" ) );
            Assert.That( dump, Is.StringContaining( "Some Desire" ) );
            Assert.That( dump, Is.StringContaining( "Wants to be present" ) );
            Assert.That( dump, Is.StringContaining( "Wants to be in A" ) );
        }

        [Test]
        public void Alice_desires_evaluation_could_change_its_inner_reality()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual, IPurposeful, IThinking >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().Add( new Position( a ) );
            alice.As< IThinking >().Imagination.Introduce( alice );

            var desire = alice.As< IPurposeful >().AddDesire(
                reality => {
                    var self = reality.Agent( alice ).As< IVirtual >();
                    self.Get< IPosition >().Location = b;
                    return self.Get< IPosition >().Location == b;
                } );

            Assert.That( desire.IsSatisfied() );
            Assert.That( alice.As< IThinking >().Imagination.Agent( alice ).As< IVirtual >().Get< IPosition >().Location, Is.EqualTo( b ) );
        }

        [Test]
        public void Alice_desire_evaluation_should_not_change_the_outer_reality()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual, IPurposeful, IThinking >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().Add( new Position( a ) );
            alice.As< IThinking >().Imagination.Introduce( alice );

            var desire = alice.As< IPurposeful >().AddDesire(
                reality => {
                    var self = reality.Agent( alice ).As< IVirtual >();
                    self.Get< IPosition >().Location = b;
                    return self.Get< IPosition >().Location == b;
                } );

            Assert.That( desire.IsSatisfied() );
            Assert.That( world.Reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location, Is.Not.EqualTo( b ) );
        }
    }
}