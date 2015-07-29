// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Rational_Tests.cs

using System;
using System.Runtime.Remoting.Messaging;
using Kolobok.Asserts;
using Kolobok.Core.Types;
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

            Assert.AreEqual( b.Id, a.As< IRational >().Present.GetAgent( b.Id ).Id);
        }

        [Test]
        public void Imaginared_agent_is_not_real()
        {
            var a = Factory.CreateAgent< IRational >();
            var b = Factory.CreateAgent();

            a.As< IRational >().Believes( world => world.Contains( b.Clone() ) );
            a.As< IRational >().Think();

            Assert.AreEqual( b.Id, a.As< IRational >().Present.GetAgent( b.Id ).Id);
            Assert.AreNotSame( b, a.As< IRational >().Present.GetAgent( b.Id ));
        }

        [Test]
        public void Agent_believes_that_its_hat_is_red()
        {
            var a = Factory.CreateAgent< IRational, IOwner >();

            a.As< IRational >().Believes( world => {
                world.Contains( a.Clone() );
                world.GetAgent( a.Id ).As< IOwner >().Set( new Hat() );
                world.GetAgent( a.Id ).As< IOwner >().Get< IHat >().Color = Colors.Red;
            } );

            a.As< IRational >().Think();

            var aColor = a.As< IRational >().Present.GetAgent( a.Id ).As< IOwner >().Get< IHat >().Color;

            Assert.AreEqual( Colors.Red, aColor );
        }
    }
}