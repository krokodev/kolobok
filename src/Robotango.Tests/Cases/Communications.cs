// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Communications.cs

using NUnit.Framework;
using Robotango.Core.Types.Attributes;
using Robotango.Core.Types.Domain.Abilities;
using Robotango.Tests.Stuff;
using Robotango.Tests.Utils;

namespace Robotango.Tests.Cases
{
    [TestFixture]
    public class Communications : BaseCase
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
        public void Non_Rationals_answer_is_invalid()
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
            var bob = Factory.CreateAgent< ICommunicative, IRational >();

            var question = alice.As< ICommunicative >().Ask< bool >( world => world.Agent( bob ) != null );
            var answer = bob.As< ICommunicative >().Reply< bool >( question );

            Log( answer.Result.Exception );

            Assert.IsFalse( answer.Result.IsVaild );
        }

        [Test]
        public void Bob_answers_about_Alicas_hat_color()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var bob = Factory.CreateAgent< ICommunicative, IRational >();

            alice.As< IVirtual >().Add( new Hat() );
            alice.As< IVirtual >().GetFirst< IHat >().Color = Colors.Red;

            bob.As< IRational >().Believes( world => { world.Add( alice ); } );
            bob.As< IRational >().Think();

            var question = alice.As< ICommunicative >().Ask< Colors >( world => world.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color );
            var answer = bob.As< ICommunicative >().Reply< Colors >( question );

            Log( answer.Result.Value );

            Assert.AreEqual( Colors.Red, answer.Result.Value );
            Assert.IsTrue( answer.Result.IsVaild );
        }

        [Test]
        public void Bob_answers_according_his_beliefes()
        {
            var alice = Factory.CreateAgent< IVirtual, ICommunicative >();
            var bob = Factory.CreateAgent< ICommunicative, IRational >();

            alice.As< IVirtual >().Add( new Hat() );
            alice.As< IVirtual >().GetFirst< IHat >().Color = Colors.Red;

            bob.As< IRational >().Believes( world => {
                var alicaImage = alice.Clone();
                world.Add( alicaImage );
                alicaImage.As< IVirtual >().Add( new Hat() );
                alicaImage.As< IVirtual >().GetFirst< IHat >().Color = Colors.Black;
            } );
            bob.As< IRational >().Think();

            var question = alice.As< ICommunicative >().Ask< Colors >( world => world.Agent( alice ).As< IVirtual >().GetFirst< IHat >().Color );
            var answer = bob.As< ICommunicative >().Reply< Colors >( question );

            Log( answer.Result.Value );

            Assert.AreEqual( Colors.Black, answer.Result.Value );
        }
    }
}