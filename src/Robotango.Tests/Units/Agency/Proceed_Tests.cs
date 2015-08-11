// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Behavioural_Tests.cs

using System.Collections.Generic;
using NUnit.Framework;
using Robotango.Common.Domain.Types.Properties;
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
        public void Proceed_uses_dependences()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IActive, IVirtual, IPurposeful, IThinking>( "Alice" )
                );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var moveAliceToB = alice.As< IActive >().CreateOperation( Activities.Virtual.Move, alice, b );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IPurposeful >().AddIntention( moveAliceToB );

            world.Proceed();

            Log( world.Dump() );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }
    }
}