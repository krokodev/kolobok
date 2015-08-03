// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Rationals.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Domain;
using Robotango.Tests.Utils.Bases;
using Robotango.Tests.Utils.Helpers;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Thinkings : BaseTests
    {
        [Test]
        public void Thinking_can_think()
        {
            var a = Factory.CreateAgent< IThinking >();
            ThinkingsAssertThat.Thinking_can_think( a );
        }

        [Test]
        public void Agent_A_believes_that_agent_B_exists()
        {
            var a = Factory.CreateAgent< IThinking >();
            var b = Factory.CreateAgent();

            a.As< IThinking >().Believes( world => world.Introduce( b.Clone() ) );
            a.As< IThinking >().Think();

            Assert.AreEqual( b.Id, a.As< IThinking >().Imagination.Agent( b ).Id );
        }

        [Test]
        public void Imaginared_agent_is_not_the_same_as_the_real()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var subj = Factory.CreateAgent();

            agent.As< IThinking >().Believes( world => world.Introduce( subj.Clone() ) );
            agent.As< IThinking >().Think();

            Assert.AreEqual( subj.Id, agent.As< IThinking >().Imagination.Agent( subj ).Id );
            Assert.AreNotSame( subj, agent.As< IThinking >().Imagination.Agent( subj ) );
        }

        [Test]
        public void Agent_believes_that_its_hat_is_red()
        {
            var agent = Factory.CreateAgent< IThinking, IVirtual >();

            var he = agent.As< IThinking >().Imagination.Introduce( agent );

            agent.As< IThinking >().Believes( world => {
                he.As< IVirtual >().Add( new Hat() );
                he.As< IVirtual >().GetFirst< IHat >().Color = Colors.Red;
            } );

            agent.As< IThinking >().Think();

            Assert.AreEqual( Colors.Red, agent.As< IThinking >().Imagination.Agent( agent ).As< IVirtual >().GetFirst< IHat >().Color );
        }

        [Test]
        public void Thinking_is_verifiable()
        {
            var agent = Factory.CreateAgent< IThinking >();

            agent.As< IThinking >().Verify();
        }

        [Test]
        public void Alice_thinks_a_lot()
        {
            var alice = Factory.CreateAgent< IThinking, IVirtual >( "Alice" );

            var herselve = alice.As< IThinking >().Imagination.Introduce( alice );

            alice.As< IThinking >().Believes( world => {
                herselve.As< IVirtual >().Add( new Hat() );
                herselve.As< IVirtual >().GetFirst< IHat >().Color = Colors.Red;
            } );

            alice.As< IThinking >().Think();
            alice.As< IThinking >().Think();
            alice.As< IThinking >().Think();
            alice.As< IThinking >().Think();

            Log( alice.As< IThinking >().Imagination.Dump() );

            alice.As< IThinking >().Verify();

            Assert.AreEqual( Colors.Red, alice.As< IThinking >().Imagination.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color );
        }

        [Test]
        public void Alice_imaginates_Bob()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.As< IThinking >().Believes( world => world.Introduce( bob.Clone() ) );
            alice.As< IThinking >().Think();

            Assert.That( alice.As< IThinking >().Imagination.Contains( bob ) );
        }

        [Test]
        public void Alice_imaginates_Bob_which_imaginates_Alice()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.As< IThinking >().Believes( world => world.Introduce( bob.Clone() ) );
            alice.As< IThinking >().Think();
            alice.As< IThinking >().Imagination.Agent( bob ).As< IThinking >().Believes( world => world.Introduce( alice.Clone() ) );
            alice.As< IThinking >().Imagination.Agent( bob ).As< IThinking >().Think();

            Assert.That( alice.As< IThinking >().Imagination.Agent( bob ).As< IThinking >().Imagination.Contains( alice ) );
        }
    }
}