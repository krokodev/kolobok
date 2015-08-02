// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Activities.cs

using NUnit.Framework;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Utils.Bases;
using Robotango.Tests.Utils.Stuff;

namespace Robotango.Tests.Cases.Complex
{
    [TestFixture]
    public class Activities : BaseTests
    {
        [Test]
        public void Aice_ask_Bob_to_pass_her()
        {
            var room = Factory.CreateReality( "The Room" );
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );
            var bob = Factory.CreateAgent< IVirtual >( "Bob" );

            var initial = new Location( "Initial" );
            var destination = new Location( "Destination" );
            var reserve = new Location( "Reserve" );

            room.Add( alice, bob );
            alice.As< IVirtual >().Add( initial );
            bob.As< IVirtual >().Add( destination );

            Log( room.Dump() );

            Assert.AreEqual( "Destination", destination.ILocation.Name );
            Assert.AreEqual( initial, alice.As< IVirtual >().GetFirst< ILocation >() );
        }
    }
}