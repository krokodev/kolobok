// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Purposes.cs

using NUnit.Framework;
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
        public void Alice_desires_to_be_in_location_A()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual, IPurposeful, IRational >( "Alice" ) );

            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().Add( new Position( a ) );
            var desire = alice.As< IPurposeful >().AddDesire(
                reality =>
                    reality.Agent( alice ).As< IVirtual >().GetFirst< IPosition >().Location == b
                );

            var dump = world.Dump();
            Log( dump);

            Assert.AreEqual(  alice.As< IRational >().Imaginary, desire.Reality);
            Assert.False( desire.IsSatisfied );
        }

        [Test]
        public void Dump_contains_desires()
        {
            var world = Factory.CreateWorld();
            var dump = world.Dump();
            Log( dump);
            Assert.Ignore();
        }

        [Test]
        public void Purposeful_agent_must_be_Thinking()
        {
            Assert.Ignore();
        }

        [Test]
        public void Desire_can_be_satisfied()
        {
            Assert.Ignore();
        }

        [Test]
        public void Testing_desire_depends_on_reality()
        {
            Assert.Ignore();
        }

        [Test]
        public void Testing_desire_could_not_change_the_reality()
        {
            Assert.Ignore();
        }

    }
}