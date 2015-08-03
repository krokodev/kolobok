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
            agent.As< IPurposeful >().AddIntention( reality => reality.Contains( agent ) == false );
            
            var dump = agent.Dump();
            Log( dump );

            Assert.That( dump.Contains( "<Purposeful>" ) );
            Assert.That( dump.Contains( "Intention" ) );
        }

        [Test]
        public void Intention_can_be_satisfied()
        {
            var agent = Factory.CreateAgent< IPurposeful, IThinking >();
            var intention = agent.As< IPurposeful >().AddIntention( reality => reality.Contains( agent ) );

            Log( agent.Dump() );

            Assert.False( intention.IsSatisfied );

            agent.As< IThinking >().Imaginary.Introduce( agent );
            
            Assert.True( intention.IsSatisfied );
        }

        [Test]
        public void Testing_intention_depends_on_reality()
        {
            Assert.Ignore();
        }

        [Test]
        public void Testing_intention_could_not_change_the_reality()
        {
            Assert.Ignore();
        }


        [Test]
        public void Alice_intends_to_think_that_she_is_in_location_B()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual, IPurposeful, IThinking >( "Alice" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().Add( new Position( a ) );
            var herself = alice.As< IThinking >().Imaginary.Introduce( alice );

            var intention = alice.As< IPurposeful >().AddIntention(
                reality =>
                    reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location == b
                );

            Log( world.Dump() );

            alice.As< IVirtual >().GetFirst< IPosition >().Location = b;

            Assert.AreEqual( alice.As< IThinking >().Imaginary, intention.Context );
            Assert.False( intention.IsSatisfied );

            herself.As< IVirtual >().GetFirst< IPosition >().Location = b;

            Assert.True( intention.IsSatisfied );
        }
    }
}