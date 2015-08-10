// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Active_Tests.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Expressions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Active_Tests : BaseTests
    {
        [Test]
        public void Activities_Operations_and_Intentions_work_properly()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            IOperation aliceMoveAliceToB = new Operation< ILocation >( alice, Activities.Virtual.Move, alice, b );
            IIntention intention = new Intention( aliceMoveAliceToB );

            intention.Execute( world.Reality );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }

        [Test]
        public void Active_is_dumped()
        {
            var world = Factory.CreateWorld();
            world.Reality.AddAgent( Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" ) );

            var dump = Log( world.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
        }

        [Test]
        public void Alice_has_intention_and_it_has_been_executed()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" )
                );
            ILocation a = new Location( "A" );
            ILocation b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            var operation = alice.As< IActive >().CreateOperation( Activities.Virtual.Move, alice, b );
            var intention = alice.As< IPurposeful >().AddIntention( operation, "Move Alice to B" );

            intention.Execute( world.Reality );

            Log( world.Dump() );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }
    }
}