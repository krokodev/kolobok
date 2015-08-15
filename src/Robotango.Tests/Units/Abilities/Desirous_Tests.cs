﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Desirous_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities;
using Robotango.Core.Elements.Virtual;
using Robotango.Tests.Common.Bases;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Desirous_Tests : BaseTests
    {
        [Test]
        public void Agent_can_be_Desirous()
        {
            Factory.CreateAgent< IDesirous, IThinking >();
        }

        [Test]
        public void Desirous_agent_may_be_not_Thinking()
        {
            Factory.CreateAgent< IDesirous >();
        }

        [Test]
        public void Desirous_dump_contains_desires()
        {
            var agent = Factory.CreateAgent< IDesirous, IThinking >();
            agent.As< IDesirous >().AddDesire( reality => reality.Contains( agent ) == false );

            var dump = Log( agent.Dump() );

            Assert.That( dump, Is.StringContaining( "<Desirous>" ) );
            Assert.That( dump, Is.StringContaining( "Desires" ) );
            Assert.That( dump, Is.StringContaining( "Some Desire" ) );
        }

        [Test]
        public void Desire_can_be_satisfied()
        {
            var agent = Factory.CreateAgent< IDesirous, IThinking >();
            var desire = agent.As< IDesirous >().AddDesire( reality => reality.Contains( agent ) );

            Log( agent.Dump() );

            Assert.False( desire.IsSatisfiedIn( agent.As< IThinking >().InnerReality ) );

            agent.As< IThinking >().InnerReality.AddAgent( agent );

            Assert.That( desire.IsSatisfiedIn( agent.As< IThinking >().InnerReality ), Is.True );
        }

        [Test]
        public void Alice_desires_to_be_in_location_B_and_is_satisfied_by_suggestion_that_she_is()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual, IDesirous, IThinking >( "Alice" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            var herself = alice.As< IThinking >().InnerReality.AddAgent( alice );

            var desire = alice.As< IDesirous >().AddDesire(
                reality =>
                    reality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >().Location == b
                );

            Log( world.Dump() );

            alice.As< IVirtual >().GetAttribute< IPosition >().Location = b;
            Assert.False( desire.IsSatisfiedIn( alice.As< IThinking >().InnerReality ) );

            alice.As< IVirtual >().GetAttribute< IPosition >().Location = a;
            herself.As< IVirtual >().GetAttribute< IPosition >().Location = b;
            Assert.True( desire.IsSatisfiedIn( alice.As< IThinking >().InnerReality ) );
        }

        [Test]
        public void Desire_can_be_named_and_names_are_dumped()
        {
            var agent = Factory.CreateAgent< IDesirous, IThinking >();

            agent.As< IDesirous >().AddDesire(
                reality => true
                );
            agent.As< IDesirous >().AddDesire(
                reality =>
                    reality.Contains( agent ),
                "Wants to be present"
                );
            var a = new Location( "A" );

            agent.As< IDesirous >().AddDesire(
                reality =>
                    reality.GetAgent( agent ).As< IVirtual >().GetAttribute< IPosition >().Location == a,
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
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual, IDesirous, IThinking >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            var desire = alice.As< IDesirous >().AddDesire(
                reality => {
                    var self = reality.GetAgent( alice ).As< IVirtual >();
                    self.GetAttribute< IPosition >().Location = b;
                    return self.GetAttribute< IPosition >().Location == b;
                } );

            Assert.That( desire.IsSatisfiedIn( alice.As< IThinking >().InnerReality ) );
            Assert.That( alice.As< IThinking >().InnerReality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >().Location, Is.EqualTo( b ) );
        }

        [Test]
        public void Alice_desire_evaluation_should_not_change_the_outer_reality()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual, IDesirous, IThinking >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            var desire = alice.As< IDesirous >().AddDesire(
                reality => {
                    var self = reality.GetAgent( alice ).As< IVirtual >();
                    self.GetAttribute< IPosition >().Location = b;
                    return self.GetAttribute< IPosition >().Location == b;
                } );

            Assert.That( desire.IsSatisfiedIn( alice.As< IThinking >().InnerReality ) );
            Assert.That( world.IReality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >().Location, Is.Not.EqualTo( b ) );
        }
    }
}