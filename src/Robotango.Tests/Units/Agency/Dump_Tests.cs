// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Dump_Tests.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Domain;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class Dump_Tests : BaseTests
    {
        [Test]
        public void Dump_contains_info_about_agents_attributes()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = universe.AddAgent( Factory.CreateAgent< IThinking, IVirtual >( "Alice" ) );
            var bob = universe.AddAgent( Factory.CreateAgent< IThinking, IVirtual >( "Bob" ) );
            var charly = universe.AddAgent( Factory.CreateAgent< IThinking, IVirtual >( "Charly" ) );

            alice.As< IThinking >().InnerReality.AddAgent( bob.Clone() );
            alice.As< IThinking >().InnerReality.AddAgent( charly.Clone() );
            alice.As< IThinking >().InnerReality.GetAgent( bob ).As< IThinking >().InnerReality.AddAgent( alice.Clone() );
            alice.As< IThinking >().InnerReality.GetAgent( bob ).As< IThinking >().InnerReality.AddAgent( bob.Clone() );

            alice.As< IVirtual >().AddAttribute< Hat >().IHat.Color = Colors.Red;
            bob.As< IVirtual >().AddAttribute< Hat >().IHat.Color = Colors.Black;

            var dump = universe.Dump();

            Log( dump );

            Assert.That( dump.Contains( "Universe" ) );
            Assert.That( dump.Contains( "Alice" ) );
            Assert.That( dump.Contains( "Bob" ) );
            Assert.That( dump.Contains( "Charly" ) );

            Assert.That( dump.Contains( "Hat" ) );
            Assert.That( dump.Contains( "Red" ) );
            Assert.That( dump.Contains( "Black" ) );
        }

        [Test]
        public void Intentions_are_dumped()
        {
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" )
                );
            ILocation a = new Location( "A" );
            ILocation b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );

            var operation = alice.As< IActive >().CreateOperation( Activities.Virtual.Move, alice, b );

            alice.As< IPurposeful >().AddIntention( operation, "Move Alice to B" );
            alice.As< IPurposeful >().AddIntention( operation );

            var dump = Log( world.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
            Assert.That( dump, Is.StringContaining( "Intentions" ) );
            Assert.That( dump, Is.StringContaining( "Move Alice to B" ) );
            Assert.That( dump, Is.StringContaining( "Some Intention" ) );
        }

        [Test]
        public void Active_is_dumped()
        {
            var world = Factory.CreateWorld();
            world.IReality.AddAgent( Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" ) );

            var dump = Log( world.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
        }

        [Test]
        public void Dependences_are_dumped()
        {
            var alice = Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive, ICommunicative >( "Alice" );
            var dump = Log( alice.Dump() );

            Assert.That( dump, Is.StringContaining( "Dependences: <Thinking> <Active>" ) );
        }

        [Ignore, Test]
        public void Activities_are_dumped()
        {
            var alice = Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" );
            var dump = Log( alice.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
            Assert.That( dump, Is.StringContaining( "Activities" ) );
            Assert.That( dump, Is.StringContaining( "Movement" ) );
        }

        [Ignore, Test]
        public void Operations_are_dumped()
        {
            var alice = Factory.CreateAgent< IVirtual, IPurposeful, IThinking, IActive >( "Alice" );
            var dump = Log( alice.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
            Assert.That( dump, Is.StringContaining( "Operations" ) );
            Assert.That( dump, Is.StringContaining( "Some Operations" ) );
        }
    }
}