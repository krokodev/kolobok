// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Communicative_Tests.cs

using NUnit.Framework;
using Robotango.Common.Types.Enums;
using Robotango.Core.Abilities.Communicative;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Virtual;
using Robotango.Tests.Base;
using Robotango.Tests.Stuff;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Communicative_Tests : BaseTests
    {
        [Test]
        public void Social_can_query_question()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var question = alice.As< ICommunicative >()
                .Ask< Colors >( world => world.GetAgent( alice ).As< IVirtual >().GetAttribute< IHat >().Color );

            Assert.AreEqual( alice.As< ICommunicative >(), question.Querist );
            Assert.NotNull( question.Querist );
        }

        [Test]
        public void Social_can_reply_answer()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var bob = Factory.CreateAgent< IVirtual, ICommunicative >();
            var question = alice.As< ICommunicative >()
                .Ask< Colors >( world => world.GetAgent( alice ).As< IVirtual >().GetAttribute< IHat >().Color );
            var answer = bob.As< ICommunicative >().Reply< Colors >( question );

            Assert.AreEqual( answer.Question, question );
            Assert.AreEqual( answer.Question.Querist, question.Querist );
            Assert.AreEqual( answer.Question.Querist, alice.As< ICommunicative >() );
            Assert.AreEqual( answer.Respondent, bob.As< ICommunicative >() );
            Assert.IsFalse( answer.Result.IsVaild );
        }

        [Test]
        public void Non_Thinkings_answer_is_invalid()
        {
            var alice = Factory.CreateAgent< ICommunicative >();
            var bob = Factory.CreateAgent< ICommunicative >();

            var question = alice.As< ICommunicative >().Ask< bool >( world => world.GetAgent( bob ) != null );
            var answer = bob.As< ICommunicative >().Reply< bool >( question );

            Log( answer.Result.Exception );

            Assert.IsFalse( answer.Result.IsVaild );
        }

        [Test]
        public void Bob_does_not_know_question_theme_so_answer_is_invalid()
        {
            var alice = Factory.CreateAgent< ICommunicative >();
            var bob = Factory.CreateAgent< ICommunicative, IThinking >();

            var question = alice.As< ICommunicative >().Ask< bool >( world => world.GetAgent( bob ) != null );
            var answer = bob.As< ICommunicative >().Reply< bool >( question );

            Log( answer.Result.Exception );

            Assert.IsFalse( answer.Result.IsVaild );
        }

        [Test]
        public void Bob_answers_about_Alicas_hat_color()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var bob = Factory.CreateAgent< ICommunicative, IThinking >();

            alice.As< IVirtual >().AddAttribute( new Hat() );
            alice.As< IVirtual >().GetAttribute< IHat >().Color = Colors.Red;

            bob.As< IThinking >().AddBelief( world => { world.AddAgent( alice ); } );
            bob.As< IThinking >().ImplementBeliefs();

            var question = alice.As< ICommunicative >()
                .Ask< Colors >( world => world.GetAgent( alice ).As< IVirtual >().GetAttribute< IHat >().Color );
            var answer = bob.As< ICommunicative >().Reply< Colors >( question );

            Log( answer.Result.Value );

            Assert.AreEqual( Colors.Red, answer.Result.Value );
            Assert.IsTrue( answer.Result.IsVaild );
        }

        [Test]
        public void Bob_answers_according_his_beliefes()
        {
            var bob = Factory.CreateAgent< ICommunicative, IThinking >();
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();

            alice.As< IVirtual >().AddAttribute( new Hat() );
            alice.As< IVirtual >().GetAttribute< IHat >().Color = Colors.Red;

            bob.As< IThinking >().InnerReality.AddAgent( alice );

            bob.As< IThinking >().AddBelief( world => {
                world.GetAgent( alice ).As< IVirtual >().AddAttribute( new Hat() );
                world.GetAgent( alice ).As< IVirtual >().GetAttribute< IHat >().Color = Colors.Black;
            } );
            bob.As< IThinking >().ImplementBeliefs();

            var question = alice.As< ICommunicative >()
                .Ask< Colors >( world => world.GetAgent( alice ).As< IVirtual >().GetAttribute< IHat >().Color );
            var answer = bob.As< ICommunicative >().Reply< Colors >( question );

            Log( answer.Result.Value );

            Assert.AreEqual( Colors.Black, answer.Result.Value );
        }
    }
}