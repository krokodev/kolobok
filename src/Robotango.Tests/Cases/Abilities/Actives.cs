// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Actives.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Actives : BaseTests
    {
        [Ignore, Test]
        public void Alice_intends_to_be_in_B_and_then_moves()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            // Use Factory

            IActivity< ILocation > move = new Activity< ILocation >( Activities.Virtual.Move );
            IOperation aliceMoveAliceToB = new Operation< ILocation >( alice, move, alice, b );

            IIntention intention = new Intention( aliceMoveAliceToB );

            intention.Execute( world.Reality );
        }
    }
}