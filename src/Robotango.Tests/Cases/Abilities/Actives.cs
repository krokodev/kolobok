// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Actives.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Expressions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Actives : BaseTests
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
        public void Alice_has_intention_and_execute_it()
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
            alice.As< IPurposeful >().AddIntention( operation );
            
            intention.Execute( world.Reality );

            var dump = Log( world.Dump() );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
            Assert.That( dump, Is.StringContaining( "<Active>" ) );
            Assert.That( dump, Is.StringContaining( "Intentions" ) );
            Assert.That( dump, Is.StringContaining( "Move Alice to B" ) );
            Assert.That( dump, Is.StringContaining( "Some Intention" ) );
        }
    }
}