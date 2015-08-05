// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Extensions.cs

using NUnit.Framework;
using Robotango.Core.Expressions;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Elements.Virtual;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Complex

{
    [TestFixture]
    public class Expressions : BaseTests
    {
        [Test]
        public void Set_agent_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var p = new Position( a );

            alice.Set( Its.Virtual.Position, p );

            Assert.That( alice.As< IVirtual >().Get< IPosition >(), Is.EqualTo( p ) );
        }

        [Test]
        public void Get_agent_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
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
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Location,  a );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Ignore, Test]
        public void Access_agent_location_via_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Position, new Position() );
            alice.Get( Its.Virtual.Position ).Location = a;

            Assert.That( alice.Get( Its.Virtual.Position ).Location, Is.EqualTo( a ) );
        }

        [Ignore, Test]
        public void Access_agent_location_directly()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Location, a );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Ignore, Test]
        public void Change_agent_location_directly()
        {
        }

        [Ignore, Test]
        public void Set_agent_location_via_Do()
        {
        }
    }
}