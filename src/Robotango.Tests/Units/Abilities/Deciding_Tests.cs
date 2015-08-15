// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Deciding_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Virtual;
using Robotango.Tests.Common.Bases;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Deciding_Tests : BaseTests
    {
        [Test]
        public void Agent_can_be_deciding()
        {
            var agent = Factory.CreateAgent< IDeciding >();
            var dump = Log( agent.Dump() );
            Assert.That( dump, Is.StringContaining( "<Deciding>" ) );
        }


        // COde: Alice_has_intention_B_and_Decides_to_move_to_B
        [Ignore, Test]
        public void Alice_has_intention_B_and_Decides_to_move_to_B()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IDesirous, IDeciding, IActive >( "alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IDesirous >().AddDesire(
                reality =>
                    reality.GetAgent( alice ).As< IVirtual >().GetAttribute< IPosition >().Location == b,
                "Desire be in B"
                );

            Log( alice.Dump() );

            alice.As< IDeciding >().Proceed( world.IReality );
            Log( alice.Dump() );

            Assert.That( alice.As< IActive >().ContainsIntention( Activities.Virtual.Move, alice, b ) );
        }

        [Ignore, Test]
        public void Alice_has_intention_B_decides_move_to_B_and_moves_to_B() {}

        [Ignore, Test]
        public void Alice_think_and_decide_to_move_to_C() {}
    }
}