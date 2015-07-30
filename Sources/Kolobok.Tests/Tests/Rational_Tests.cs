// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Rational_Tests.cs

using Kolobok.Asserts;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using Kolobok.Core.Utils;
using Kolobok.Stuff;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Rational_Tests : BaseTests
    {
        [Test]
        public void Rational_can_think()
        {
            var a = Factory.CreateAgent< IRational >();
            RationalsAssertThat.Rational_can_think( a );
        }

        [Test]
        public void Agent_A_believes_that_agent_B_exists()
        {
            var a = Factory.CreateAgent< IRational >();
            var b = Factory.CreateAgent();

            a.As< IRational >().Believes( world => world.Contains( b.Clone() ) );
            a.As< IRational >().Think();

            Assert.AreEqual( b.Id, a.As< IRational >().Imaginary.Agent( b ).Id );
        }

        [Test]
        public void Imaginared_agent_is_not_the_same_as_the_real()
        {
            var agent = Factory.CreateAgent< IRational >();
            var subj = Factory.CreateAgent();

            agent.As< IRational >().Believes( world => world.Contains( subj.Clone() ) );
            agent.As< IRational >().Think();

            Assert.AreEqual( subj.Id, agent.As< IRational >().Imaginary.Agent( subj ).Id );
            Assert.AreNotSame( subj, agent.As< IRational >().Imaginary.Agent( subj ) );
        }

        [Test]
        public void Agent_believes_that_its_hat_is_red()
        {
            var agent = Factory.CreateAgent< IRational, IOwner >();

            agent.As< IRational >().Believes( world => {
                var subj = agent.Clone();
                world.Contains( subj );
                subj.As< IOwner >().Has( new Hat() );
                subj.As< IOwner >().GetFirst< IHat >().Color = Colors.Red;
            } );

            agent.As< IRational >().Think();

            Assert.AreEqual( Colors.Red, agent.As< IRational >().Imaginary.Agent( agent ).As< IOwner >().GetFirst< IHat >().Color );
        }

        [Test]
        public void Rational_is_verifiable()
        {
            var agent = Factory.CreateAgent< IRational >();

            agent.As< IRational >().Verify();
        }

    }
}