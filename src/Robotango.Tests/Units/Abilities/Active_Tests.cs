// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Active_Tests.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Expressions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Active_Tests : BaseTests
    {
        [Test]
        public void Activities_Operations_and_Intentions_work_properly()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            IOperation aliceMoveAliceToB = new Operation< ILocation >( Activities.Virtual.Move, alice, b );
            IIntention intention = new Intention( aliceMoveAliceToB );

            intention.Realize( world.IReality );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }

        [Test]
        public void Alice_has_intention_and_it_has_been_executed()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" )
                );
            ILocation a = new Location( "A" );
            ILocation b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            var operation = alice.As< IActive >().CreateOperation( Activities.Virtual.Move, alice, b );
            var intention = alice.As< IPurposeful >().AddIntention( operation, "Move Alice to B" );

            intention.Realize( world.IReality );

            Log( world.Dump() );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }

        [Test]
        public void World_thinks_that_Alice_goes_to_B()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var moveAliceToB = alice.As< IActive >().CreateOperation( Activities.Virtual.Move, alice, b );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IPurposeful >().AddIntention( moveAliceToB );

            Log( world.Dump() );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            world.Proceed();

            Log( world.Dump() );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }

        [Test]
        public void Alice_thinks_that_she_goes_to_B_but_in_really_not()
        {
            var world = Factory.CreateWorld();
            var alice0 = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IThinking, IPurposeful, IActive >( "Alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var moveAliceToB = alice0.As< IActive >().CreateOperation( Activities.Virtual.Move, alice0, b );

            alice0.As< IVirtual >().AddAttribute( new Position( a ) );
            alice0.As< IPurposeful >().AddIntention( moveAliceToB );
            var alice1 = alice0.As< IThinking >().InnerReality.AddAgent( alice0 );
            Log( world.Dump() );

            alice0.Proceed( world.IReality );

            Log( world.Dump() );
            Assert.That( alice1.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
            Assert.That( alice0.Get( Its.Virtual.Location ), Is.Not.EqualTo( b ) );
        }

        [Test]
        public void Alice_has_adequate_selfimage()
        {
            var a = new Location( "A" );
            var b = new Location( "B" );
            var world = Factory.CreateWorld();
            var alice = Factory.CreateAgent< IVirtual, IThinking, IPurposeful, IActive >( "Alice" );
            var moveToB = alice.As< IActive >().CreateOperation( Activities.Virtual.Move, alice, b );
            alice.As< IVirtual >().AddAttribute( new Position( a ) );

            alice.As< IPurposeful >().AddIntention( moveToB, "moveToB" );

            var wAlice = world.IReality.AddAgent( alice, "wAlice" );
            var aAlice = wAlice.As< IThinking >().InnerReality.AddAgent( wAlice, "aAlice" );

            Log( world.Dump() );
            {
                world.Proceed();
            }
            Log( world.Dump() );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
            Assert.That( wAlice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
            Assert.That( aAlice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }

        [Test]
        public void Bob_has_inadequate_selfimage()
        {
            var a = new Location( "A" );
            var b = new Location( "B" );
            var world = Factory.CreateWorld();
            var bob = Factory.CreateAgent< IVirtual, IThinking, IPurposeful, IActive >( "Bob" );
            var moveToB = bob.As< IActive >().CreateOperation( Activities.Virtual.Move, bob, b );
            bob.As< IVirtual >().AddAttribute( new Position( a ) );

            var wBob = world.IReality.AddAgent( bob, "wBob" );
            var bBob = wBob.As< IThinking >().InnerReality.AddAgent( wBob, "bBob" );

            wBob.As< IPurposeful >().AddIntention( moveToB, "moveToB" );

            Log( world.Dump() );
            {
                world.Proceed();
            }
            Log( world.Dump() );

            Assert.That( bob.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
            Assert.That( wBob.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
            Assert.That( bBob.Get( Its.Virtual.Location ), Is.Not.EqualTo( b ) );
        }
    }
}