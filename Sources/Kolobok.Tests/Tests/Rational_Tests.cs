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
        public void Agent_believes_other_exists()
        {
            var a = Factory.CreateAgent< IRational, IWorld >();
            var b = Factory.CreateAgent();

            a.As< IRational >().Believes( world => world.Contains( b ) );
            a.As< IRational >().Think();

            var bId = a.As< IRational >().Present.Agent( b ).Id;

            Log( b.Id );
            Log( bId );

            Assert.AreEqual( b.Id, bId);
        }

        [Ignore]
        [Test]
        public void Agent_belief_that_its_hat_is_red()
        {
            var a = Factory.CreateAgent< IRational, IWorld >();

            a.As< IRational >().Believes( w => {
                w.Contains( a );
                w.Agent( a ).As< IComposition >().Get< Hat >().Color = Hat.Colors.Red;
            } );
            
            //a.As< IRational >().Think();

            var agentSelfColor = a.As< IWorld >().Agent( a ).As< IComposition >().Get< Hat >().Color;

            Assert.Equals(  Hat.Colors.Red, agentSelfColor );
        }
    }
}