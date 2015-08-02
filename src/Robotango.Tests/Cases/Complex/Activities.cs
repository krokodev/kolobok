// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Activities.cs

using NUnit.Framework;
using Robotango.Core.Implements.Domain.Virtuals;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Domain.Virtuals;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Complex
{
    [TestFixture]
    public class Activities : BaseTests
    {
        [Test]
        public void Alice_asks_Bob_to_pass_her()
        {
            var house = Factory.CreateReality( "The House" );
            var alice = Factory.CreateAgent< IVirtual >( "Alice" );
            var bob = Factory.CreateAgent< IVirtual >( "Bob" );

            var initial = new Location( "Initial" );
            var destination = new Location( "Destination" );
            var reserve = new Location( "Reserve" );

            house.Add( alice, bob );
            alice.As< IVirtual >().Add( new Position( initial ) );
            bob.As< IVirtual >().Add( new Position( destination ) );

            Log( house.Dump() );

            Assert.AreEqual( "Destination", destination.ILocation.Name );
            Assert.AreEqual( initial, alice.As< IVirtual >().GetFirst< IPosition >().Location );
        }
    }
}