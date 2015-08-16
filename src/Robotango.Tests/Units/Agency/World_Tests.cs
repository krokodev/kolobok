// Robotango (c) 2015 Krokodev
// Robotango.Tests
// World_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities;
using Robotango.Core.Elements.Virtual;
using Robotango.Tests.Base;

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
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );

            alice.As< IVirtual >().AddAttribute( new Position( locA ) );

            Log( world.Dump() );

            Assert.AreEqual( "The World", world.Name );
            Assert.AreSame( world.IReality, world.IThinking.InnerReality );
            Assert.That( world.IReality.Contains( alice ) );
        }

        [Test]
        public void World_can_think_and_change_reality()
        {
            var locA = new Location( "A" );
            var locB = new Location( "B" );
            var world = Factory.CreateWorld( "The World" );
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IVirtual >( "Alice" ) );

            alice.As< IVirtual >().AddAttribute( new Position( locA ) );
            world.IThinking.AddBelief( reality => { reality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >().Location = locB; } );

            Log( world.Dump() );
            Log( alice.Dump() );

            Assert.AreEqual( "The World", world.Name );
            Assert.True( world.IReality.Contains( alice ) );
            Assert.AreEqual( locA, alice.As< IVirtual >().GetAttribute< IPosition >().Location );

            Log( "Thinking...\n" );

            world.IThinking.ImplementBeliefs();

            Log( world.Dump() );

            Assert.That( world.IReality.Contains( alice ) );
            Assert.AreEqual( locB, alice.As< IVirtual >().GetAttribute< IPosition >().Location );
        }
    }
}