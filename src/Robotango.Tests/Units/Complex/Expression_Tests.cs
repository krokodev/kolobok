// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Expression_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Thinking.Beliefs_XXXX;
using Robotango.Core.Abilities.Virtual;
using Robotango.Core.Abilities.Virtual.Imp;
using Robotango.Expressions.Terms;
using Robotango.Tests.Base;

namespace Robotango.Tests.Units.Complex

{
    [TestFixture]
    public class Expression_Tests : BaseTests
    {
        [Test]
        public void Set_agent_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var p = new Position( a );

            alice.Set( Its.Virtual.Position, p );

            Assert.That( alice.As< IVirtual >().GetAttribute< IPosition >(), Is.EqualTo( p ) );
        }

        [Test]
        public void Get_agent_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var p = new Position( a );
            alice.Set( Its.Virtual.Position, p );

            var pos = alice.Get( Its.Virtual.Position );

            Assert.That( pos, Is.EqualTo( p ) );
        }

        [Test]
        public void Set_agent_location_directly()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Location, a );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Test]
        public void Access_agent_location_via_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Position, new Position() );
            alice.Get( Its.Virtual.Position ).Location = a;

            Assert.That( alice.Get( Its.Virtual.Position ).Location, Is.EqualTo( a ) );
        }

        [Test]
        public void Access_agent_location_directly()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Location, a );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Test]
        public void Change_agent_location_deirectly()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );

            alice.Set( Its.Virtual.Location, a );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            alice.Set( Its.Virtual.Location, b );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );

            alice.Set( Its.Virtual.Location, c );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( c ) );

            alice.Set( Its.Virtual.Location, a );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            Log( world.Dump() );
        }

        [Test]
        public void Change_agent_location_via_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );

            alice.Set( Its.Virtual.Location, a );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            alice.Set( Its.Virtual.Location, b );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );

            alice.Set( Its.Virtual.Location, c );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( c ) );

            alice.Get( Its.Virtual.Position ).Location = a;
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Test]
        public void Alice_Introduce_Bob_()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.Do( As.Thinking.Know( bob ) );

            Assert.That( alice.As< IThinking >().InnerReality.Contains( bob ) );
        }

        [Test]
        public void Alice_Introduce_Herself()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );

            alice.Do( As.Thinking.Know( Its.Self ) );

            Assert.That( alice.As< IThinking >().InnerReality.Contains( alice ) );
        }

        [Test]
        public void Alice_Is_Knowing_Bob()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            var knowsBob = alice
                .Do( As.Thinking.Know( bob ) )
                .Is( As.Thinking.Knowing( bob ) );

            Assert.That( knowsBob );
        }

        [Test]
        public void Alice_Do_Believe()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var belief = new Belief( reality => { } );

            alice.Do( As.Thinking.Believe( belief ) );

            Assert.That( alice.As< IThinking >().HasBelief( belief ) );
        }

        [Test]
        public void Alice_Is_Believing()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var belief = new Belief( reality => { } );

            var hasBelief = alice
                .Do( As.Thinking.Believe( belief ) )
                .Is( As.Thinking.Believing( belief ) );

            Assert.That( hasBelief );
        }
    }
}