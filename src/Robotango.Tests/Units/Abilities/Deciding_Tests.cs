// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Deciding_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities.Active;
using Robotango.Core.Abilities.Desirous;
using Robotango.Core.Abilities.Desirous.Imp;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Virtual;
using Robotango.Core.Abilities.Virtual.Imp;
using Robotango.Core.Common;
using Robotango.Expressions.Terms;
using Robotango.Tests.Base;

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
            Assert.That( dump, Is.StringContaining( "<DecidingAbility>" ) );
        }

        [Test]
        public void Alice_desires_B_and_Decides_to_move_to_B()
        {
            var world = Factory.CreateWorld();
            var alice =
                world.IReality.AddAgent( Factory.CreateAgent< IVirtual, IDesirous, IDeciding, IActive >( "alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IActive >().AddActivity( Lib.Activities.Movement );
            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IDesirous >().AddDesire( new LocationDesire( alice, b ) );

            Log( alice.Dump() );

            alice.As< IDeciding >().MakeDecision( world.IReality );
            alice.As< IDeciding >().Proceed( world.IReality );
            Log( alice.Dump() );

            Assert.That( alice.As< IActive >().ContainsIntention( Lib.Activities.Movement, alice, b ) );
        }

        [Test]
        public void Alice_desires_be_in_B_then_decides_move_to_B_and_then_moves_to_B()
        {
            var world = Factory.CreateWorld();
            var alice =
                world.IReality.AddAgent( Factory.CreateAgent< IVirtual, IDesirous, IDeciding, IActive >( "alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );

            alice.As< IActive >().AddActivity( Lib.Activities.Movement );
            alice.As< IVirtual >().AddAttribute( new Position( a ) );
            alice.As< IDesirous >().AddDesire( new LocationDesire( alice, b ) );

            Log( alice.Dump() );

            world.Proceed();

            Log( alice.Dump() );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
            Assert.False( alice.As< IActive >().ContainsIntention( Lib.Activities.Movement, alice, b ) );
        }

        [Test]
        public void Alice_desires_meet_Bob_then_she_thinks_and_decides_to_move_to_B()
        {
            // todo:> let IThinking.InnerReality points to one of the ThinkingProcess's reality
            var world = Factory.CreateWorld();
            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );
            var alice =
                world.IReality.AddAgent(
                    Factory.CreateAgent< IVirtual, IDesirous, IThinking, IDeciding, IActive >( "alice" ) );
            var bob =
                alice.As< IThinking >()
                    .InnerReality.AddAgent(
                        Factory.CreateAgent< IVirtual, IDesirous, IThinking, IDeciding, IActive >( "bob" ) );
            // todo:> use extentions to simify: bob.AddPosiotion(c), bob.AddLocationDesire(b)
            bob.As< IVirtual >().AddAttribute( new Position( c ) );
            bob.As< IActive >().AddActivity( Lib.Activities.Movement );
            bob.As< IDesirous >().AddDesire( new LocationDesire( bob, b ) );

            alice.As< IVirtual >().AddAttribute( new Position( c ) );
            alice.As< IActive >().AddActivity( Lib.Activities.Movement );
//            alice.As< IDesirous >().AddDesire( new MeetingDesire( bob ) );

            world.Proceed();

            Log( alice.Dump() );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
            Assert.That( bob.Get( Its.Virtual.Location ), Is.EqualTo( b ) );
        }
    }
}