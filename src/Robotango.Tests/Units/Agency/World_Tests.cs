// Robotango (c) 2015 Krokodev
// Robotango.Tests
// World_Tests.cs

using NUnit.Framework;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class World_Tests : BaseTests
    {
        [Test]
        public void World_has_properties()
        {
            var locA = new Location( "A" );
            var world = Factory.CreateWorld( "The World" );
            var alice = world.Reality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );

            alice.As< IVirtual >().AddAttribute( new Position( locA ) );

            Log( world.Dump() );

            Assert.AreEqual( "The World", world.Name );
            Assert.AreSame( world.Reality, world.Thinking.InnerReality );
            Assert.That( world.Reality.Contains( alice ) );
        }

        [Test]
        public void World_can_think_and_change_reality()
        {
            var locA = new Location( "A" );
            var locB = new Location( "B" );
            var world = Factory.CreateWorld( "The World" );
            var alice = world.Reality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );

            alice.As< IVirtual >().AddAttribute( new Position( locA ) );
            world.Thinking.AddBelief( reality => { reality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >().Location = locB; } );

            Log( world.Dump() );
            Log( alice.Dump() );

            Assert.AreEqual( "The World", world.Name );
            Assert.True( world.Reality.Contains( alice ) );
            Assert.AreEqual( locA, alice.As< IVirtual >().GetAttribute< IPosition >().Location );

            Log( "Thinking...\n" );

            world.Thinking.Think();

            Log( world.Dump() );

            Assert.That( world.Reality.Contains( alice ) );
            Assert.AreEqual( locB, alice.As< IVirtual >().GetAttribute< IPosition >().Location );
        }
    }
}