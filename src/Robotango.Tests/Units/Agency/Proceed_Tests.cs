// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Proceed_Tests.cs

using NUnit.Framework;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Expressions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class Proceed_Tests : BaseTests
    {
        [Test]
        public void Abilities_ordering_cause_on_the_proceed_success()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent( Factory.CreateAgent< IActive, IVirtual, IPurposeful, IThinking >( "Alice" ) );
            var bob = world.IReality.AddAgent( Factory.CreateAgent< IThinking, IVirtual, IPurposeful, IActive >( "Bob" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );

            var moveAliceToB = alice.As< IActive >().CreateOperation( Activities.Virtual.Move, alice, b );
            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IPurposeful >().AddIntention( moveAliceToB );

            var moveBobToB = bob.As< IActive >().CreateOperation( Activities.Virtual.Move, bob, b );
            bob.As< IVirtual >().AddAttribute( new Position( a ) );
            bob.As< IPurposeful >().AddIntention( moveBobToB );

            world.Proceed();

            Log( world.Dump() );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.Not.EqualTo( b ) );
            Assert.That( bob.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }
    }
}