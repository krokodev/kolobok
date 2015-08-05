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
        public void Alice_set_position_via_action()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Do( Set.Virtual.Position( a ) );

            Assert.That( alice.As< IVirtual >().Get< IPosition >().Location, Is.EqualTo( a ) );
        }

        [Test]
        public void Alice_get_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Do( Set.Virtual.Position( a ) );
            var pos = alice.Get( Its.Virtual.Position );

            Assert.That( pos.Location, Is.EqualTo( a ) );
        }

        [Ignore,Test]
        public void Alice_set_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            //alice.Set( Its.Virtual.Position,  a );

            //Assert.That( alice.Get( Its.Virtual.Position ).Location, Is.EqualTo( a ) );
        }
    }
}