// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Purposes.cs

using NUnit.Framework;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Elements.Virtual;
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
        public void Purposeful_dump_contains_intentions()
        {
            var agent = Factory.CreateAgent< IPurposeful, IThinking >();
            agent.As< IPurposeful >().Intends( reality => reality.Contains( agent ) == false );

            var dump = Log( agent.Dump() );

            Assert.That( dump.Contains( "<Purposeful>" ) );
            Assert.That( dump.Contains( "Intention" ) );
        }

        [Test]
        public void Intention_can_be_satisfied()
        {
            var agent = Factory.CreateAgent< IPurposeful, IThinking >();
            var intention = agent.As< IPurposeful >().Intends( reality => reality.Contains( agent ) );

            Log( agent.Dump() );

            Assert.False( intention.IsSatisfied() );

            agent.As< IThinking >().Imagination.Introduce( agent );

            Assert.That( intention.IsSatisfied(), Is.True );
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

            var intention = alice.As< IPurposeful >().Intends(
                reality =>
                    reality.Agent( alice ).As< IVirtual >().Get< IPosition >().Location == b
                );

            Log( world.Dump() );

            alice.As< IVirtual >().Get< IPosition >().Location = b;
            Assert.False( intention.IsSatisfied() );

            alice.As< IVirtual >().Get< IPosition >().Location = a;
            herself.As< IVirtual >().Get< IPosition >().Location = b;
            Assert.True( intention.IsSatisfied() );
        }

        [Test]
        public void Intention_can_be_named_and_names_are_dumped()
        {
            var agent = Factory.CreateAgent< IPurposeful, IThinking >();
            var a = new Location( "A" );

            agent.As< IPurposeful >().Intends(
                reality => true
                );
            agent.As< IPurposeful >().Intends(
                reality =>
                    reality.Contains( agent ),
                "Wants to be present"
                );
            agent.As< IPurposeful >().Intends(
                reality =>
                    reality.Agent( agent ).As< IVirtual >().Get< IPosition >().Location == a,
                "Wants to be in A"
                );

            var dump = Log( agent.Dump() );

            Assert.That( dump, Is.StringContaining( "Some Agent" ) );
            Assert.That( dump, Is.StringContaining( "Some Intention" ) );
            Assert.That( dump, Is.StringContaining( "Wants to be present" ) );
            Assert.That( dump, Is.StringContaining( "Wants to be in A" ) );
        }


        [Test]
        public void Alice_intention_evaluation_could_change_its_inner_reality()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce(Factory.CreateAgent< IVirtual, IPurposeful, IThinking >("Alice"));
            var a = new Location( "A" );
            var b = new Location( "B" );
            
            alice.As<IVirtual>().Add( new Position(a));
            alice.As< IThinking >().Imagination.Introduce( alice );

            var intention = alice.As< IPurposeful >().Intends(
                reality => {
                    var self = reality.Agent( alice ).As< IVirtual >();
                    self.Get< IPosition >().Location = b;
                    return self.Get< IPosition >().Location == b;
                } );

            Assert.That(intention.IsSatisfied());
            Assert.That(alice.As<IThinking>().Imagination.Agent( alice ).As<IVirtual>().Get<IPosition>().Location, Is.EqualTo( b ));
        }


        [Test]
        public void Alice_intention_evaluation_should_not_change_the_outer_reality()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce(Factory.CreateAgent< IVirtual, IPurposeful, IThinking >("Alice"));
            var a = new Location( "A" );
            var b = new Location( "B" );
            
            alice.As<IVirtual>().Add( new Position(a));
            alice.As< IThinking >().Imagination.Introduce( alice );

            var intention = alice.As< IPurposeful >().Intends(
                reality => {
                    var self = reality.Agent( alice ).As< IVirtual >();
                    self.Get< IPosition >().Location = b;
                    return self.Get< IPosition >().Location == b;
                } );

            Assert.That(intention.IsSatisfied());
            Assert.That(world.Reality.Agent( alice ).As<IVirtual>().Get<IPosition>().Location, Is.Not.EqualTo( b ));
        }
    }
}