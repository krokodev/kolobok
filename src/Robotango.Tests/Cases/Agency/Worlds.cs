// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Worlds.cs

using NUnit.Framework;
using Robotango.Core.Implements.Domain.Virtuals;
using Robotango.Core.Types.Abilities;
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

            var dump = world.Dump();
            Log(dump);

            Assert.AreEqual( "The World", world.Name );
            Assert.That( world.Reality.Contains( alice ) );
        }

        [Test]
        public void World_can_think_and_change_reality()
        {
            Assert.Ignore();;
        }
    }
}