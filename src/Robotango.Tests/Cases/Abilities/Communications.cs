// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Communications.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Domain;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Communications : BaseTests
    {
        [Test]
        public void Social_can_query_question()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var question = alice.As< ICommunicative >().Ask< Colors >( world => world.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color );

            Assert.AreEqual( alice.As< ICommunicative >(), question.Querist );
            Assert.NotNull( question.Querist );
        }

        [Test]
        public void Social_can_reply_answer()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var bob = Factory.CreateAgent< IVirtual, ICommunicative >();
            var question = alice.As< ICommunicative >().Ask< Colors >( world => world.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color );
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

            var question = alice.As< ICommunicative >().Ask< bool >( world => world.Agent( bob ) != null );
            var answer = bob.As< ICommunicative >().Reply< bool >( question );

            Log( answer.Result.Exception );

            Assert.IsFalse( answer.Result.IsVaild );
        }

        [Test]
        public void Bob_does_not_know_question_theme_so_answer_is_invalid()
        {
            var alice = Factory.CreateAgent< ICommunicative >();
            var bob = Factory.CreateAgent< ICommunicative, IThinking >();

            var question = alice.As< ICommunicative >().Ask< bool >( world => world.Agent( bob ) != null );
            var answer = bob.As< ICommunicative >().Reply< bool >( question );

            Log( answer.Result.Exception );

            Assert.IsFalse( answer.Result.IsVaild );
        }

        [Test]
        public void Bob_answers_about_Alicas_hat_color()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var bob = Factory.CreateAgent< ICommunicative, IThinking >();

            alice.As< IVirtual >().Add( new Hat() );
            alice.As< IVirtual >().GetFirst< IHat >().Color = Colors.Red;

            bob.As< IThinking >().Believes( world => { world.Introduce( alice ); } );
            bob.As< IThinking >().Think();

            var question = alice.As< ICommunicative >().Ask< Colors >( world => world.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color );
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

            alice.As< IVirtual >().Add( new Hat() );
            alice.As< IVirtual >().GetFirst< IHat >().Color = Colors.Red;

            bob.As< IThinking >().Imagination.Introduce( alice );

            bob.As< IThinking >().Believes( world => {
                world.Agent( alice ).As< IVirtual >().Add( new Hat() );
                world.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color = Colors.Black;
            } );
            bob.As< IThinking >().Think();

            var question = alice.As< ICommunicative >().Ask< Colors >( world => world.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color );
            var answer = bob.As< ICommunicative >().Reply< Colors >( question );

            Log( answer.Result.Value );

            Assert.AreEqual( Colors.Black, answer.Result.Value );
        }
    }
}