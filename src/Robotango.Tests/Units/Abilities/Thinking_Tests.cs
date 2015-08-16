// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Thinking_Tests.cs

using NUnit.Framework;
using Robotango.Common.Types.Enums;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Virtual;
using Robotango.Tests.Base;
using Robotango.Tests.Stuff;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Thinking_Tests : BaseTests
    {
        [Test]
        public void Agent_can_think()
        {
            var agent = Factory.CreateAgent< IThinking >();
            agent.As< IThinking >().ImplementBeliefs();
        }

        [Test]
        public void Agent_A_believes_that_agent_B_exists()
        {
            var a = Factory.CreateAgent< IThinking >();
            var b = Factory.CreateAgent();

            a.As< IThinking >().AddBelief( world => world.AddAgent( b.Clone() ) );
            a.As< IThinking >().ImplementBeliefs();

            Assert.AreEqual( b.Id, a.As< IThinking >().InnerReality.GetAgent( b ).Id );
        }

        [Test]
        public void Imaginared_agent_is_not_the_same_as_the_real()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var subj = Factory.CreateAgent();

            agent.As< IThinking >().AddBelief( world => world.AddAgent( subj.Clone() ) );
            agent.As< IThinking >().ImplementBeliefs();

            Assert.AreEqual( subj.Id, agent.As< IThinking >().InnerReality.GetAgent( subj ).Id );
            Assert.AreNotSame( subj, agent.As< IThinking >().InnerReality.GetAgent( subj ) );
        }

        [Test]
        public void Agent_believes_that_its_hat_is_red()
        {
            var agent = Factory.CreateAgent< IThinking, IVirtual >();

            var he = agent.As< IThinking >().InnerReality.AddAgent( agent );

            agent.As< IThinking >().AddBelief( world => {
                he.As< IVirtual >().AddAttribute( new Hat() );
                he.As< IVirtual >().GetAttribute< IHat >().Color = Colors.Red;
            } );

            agent.As< IThinking >().ImplementBeliefs();

            Assert.AreEqual( Colors.Red, agent.As< IThinking >().InnerReality.GetAgent( agent ).As< IVirtual >().GetAttribute< IHat >().Color );
        }

        [Test]
        public void Alice_thinks_a_lot()
        {
            var alice = Factory.CreateAgent< IThinking, IVirtual >( "Alice" );

            var herselve = alice.As< IThinking >().InnerReality.AddAgent( alice );

            alice.As< IThinking >().AddBelief( world => {
                herselve.As< IVirtual >().AddAttribute( new Hat() );
                herselve.As< IVirtual >().GetAttribute< IHat >().Color = Colors.Red;
            } );

            alice.As< IThinking >().ImplementBeliefs();
            alice.As< IThinking >().ImplementBeliefs();
            alice.As< IThinking >().ImplementBeliefs();
            alice.As< IThinking >().ImplementBeliefs();

            Log( alice.As< IThinking >().InnerReality.Dump() );

            Assert.AreEqual( Colors.Red, alice.As< IThinking >().InnerReality.GetAgent( alice ).As< IVirtual >().GetAttribute< IHat >().Color );
        }

        [Test]
        public void Alice_imaginates_Bob()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.As< IThinking >().AddBelief( world => world.AddAgent( bob.Clone() ) );
            alice.As< IThinking >().ImplementBeliefs();

            Assert.That( alice.As< IThinking >().InnerReality.Contains( bob ) );
        }

        [Test]
        public void Alice_imaginates_Bob_which_imaginates_Alice()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.As< IThinking >().AddBelief( world => world.AddAgent( bob.Clone() ) );
            alice.As< IThinking >().ImplementBeliefs();
            alice.As< IThinking >().InnerReality.GetAgent( bob ).As< IThinking >().AddBelief( world => world.AddAgent( alice.Clone() ) );
            alice.As< IThinking >().InnerReality.GetAgent( bob ).As< IThinking >().ImplementBeliefs();

            Assert.That( alice.As< IThinking >().InnerReality.GetAgent( bob ).As< IThinking >().InnerReality.Contains( alice ) );
        }
    }
}