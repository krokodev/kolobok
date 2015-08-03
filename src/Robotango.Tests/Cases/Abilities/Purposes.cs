// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Purposes.cs

using NUnit.Framework;
using Robotango.Core;
using Robotango.Core.Implements.Domain.Virtuals;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Domain.Virtuals;
using Robotango.Tests.Cases.Complex;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Purposes : BaseTests
    {
        [Test]
        public void Alice_has_puproses()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().Add( new Position( a ) );
            var des = alice.As< IPurposeful >().Desires( reality => reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location == b );

            // dump desires!
            Log( world.Dump() );


            Assert.Ignore();
        }
    }
}