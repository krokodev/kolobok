// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Deciding_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities;
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

        [Test]
        public void Alice_has_intention_B_and_Decides_to_move()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IActive, IDeciding >( "alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            
            var dump = Log( alice.Dump() );
            

//            Assert.That( dump, Is.StringContaining( "<Deciding>" ) );
        }

        [Ignore, Test]
        public void Alice_think_and_decide_to_go_to_C() {}
    }
}