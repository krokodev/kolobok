// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Worlds.cs

using NUnit.Framework;
using Robotango.Core.Implements.Domain.Virtuals;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Domain.Virtuals;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Agency
{
    [TestFixture]
    public class Worlds : BaseTests
    {
        [Test]
        public void World_has_properties()
        {
            var locA = new Location( "A" );
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );
            var world = Factory.CreateWorld( "The World" );

            alice.As< IVirtual >().Add( new Position( locA ) );
            world.Reality.Add( alice );

            Log( world.Dump() );

            Assert.AreEqual( "The World", world.Name );
            Assert.AreSame( world.Reality, world.Rational.Imaginary );
            Assert.That( world.Reality.Contains( alice ) );
        }

        [Test]
        public void World_can_think_and_change_reality()
        {
            var locA = new Location( "A" );
            var locB = new Location( "B" );
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );
            var world = Factory.CreateWorld( "The World" );

            alice.As< IVirtual >().Add( new Position( locA ) );

            world.Rational.Believes( reality => {
                reality.Add( alice );
                reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location = locB;
            } );

            Log( world.Dump() );
            Log( alice.Dump() );

            Assert.AreEqual( "The World", world.Name );
            Assert.False( world.Reality.Contains( alice ) );
            Assert.AreEqual( locA, alice.As< IVirtual >().GetFirst< IPosition >().Location );

            Log( "Thinking...\n" );

            world.Rational.Think();

            Log( world.Dump() );

            Assert.That( world.Reality.Contains( alice ) );
            Assert.AreEqual( locB, alice.As< IVirtual >().GetFirst< IPosition >().Location );
        }
    }
}