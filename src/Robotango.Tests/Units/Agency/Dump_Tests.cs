// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Dump_Tests.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Abilities;
using Robotango.Core.Common;
using Robotango.Core.Elements.Virtual;
using Robotango.Tests.Base;
using Robotango.Tests.Domain;

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
                Factory.CreateAgent< IVirtual, IDesirous, IThinking, IActive >( "Alice" )
                );
            ILocation a = new Location( "A" );
            ILocation b = new Location( "B" );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IThinking >().InnerReality.AddAgent( alice );
            alice.As< IActive >().AddActivity( Lib.Activities.Movement );

            alice.As< IActive >().AddIntention( Lib.Activities.Movement, alice, b );

            var dump = Log( world.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
            Assert.That( dump, Is.StringContaining( "Intentions" ) );
            Assert.That( dump, Is.StringContaining( "MoveTo(Alice,B)" ) );
        }

        [Test]
        public void Active_is_dumped()
        {
            var world = Factory.CreateWorld();
            world.IReality.AddAgent( Factory.CreateAgent< IVirtual, IDesirous, IThinking, IActive >( "Alice" ) );

            var dump = Log( world.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
        }

        [Test]
        public void Dependences_are_dumped()
        {
            var alice = Factory.CreateAgent< IVirtual, IDesirous, IThinking, IActive, ICommunicative >( "Alice" );
            var dump = Log( alice.Dump() );

            Assert.That( dump, Is.StringContaining( "use: <Thinking>" ) );
        }

        [Test]
        public void Operations_are_dumped()
        {
            var a = new Location( "A" );
            var b = new Location( "B" );
            var world = Factory.CreateWorld();
            var alice = world.IReality.AddAgent(
                Factory.CreateAgent< IVirtual, IThinking, IDesirous, IActive >( "Alice" )
                );
            alice.As< IActive >().AddActivity( Lib.Activities.Movement );

            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IActive >().AddIntention( Lib.Activities.Movement, alice, b );
            alice.As< IThinking >().InnerReality.AddAgent( alice, "aAlice" );

            alice.As< IDesirous >().Proceed( world.IReality );

            var dump1 = Log( world.Dump() );
            {
                world.Proceed();
            }
            var dump2 = Log( world.Dump() );

            Assert.That( dump1, Is.StringContaining( "<Active>" ) );
            Assert.That( dump1, Is.StringContaining( "Intentions" ) );
            Assert.That( dump1, Is.StringContaining( "MoveTo(Alice,B)" ) );
            Assert.That( dump2, Is.Not.StringContaining( "MoveTo(Alice,B)" ) );
        }

        [Test]
        public void Activities_are_dumped()
        {
            var alice = Factory.CreateAgent< IVirtual, IDesirous, IThinking, IActive >( "Alice" );

            alice.As< IActive >().AddActivity( Lib.Activities.Movement );

            var dump = Log( alice.Dump() );

            Assert.That( dump, Is.StringContaining( "<Active>" ) );
            Assert.That( dump, Is.StringContaining( "Activities" ) );
            Assert.That( dump, Is.StringContaining( "MoveTo(IAgent,ILocation)" ) );
        }
    }
}