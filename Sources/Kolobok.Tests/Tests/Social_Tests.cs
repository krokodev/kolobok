// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Social_Tests.cs

using Kolobok.Core.Types;
using Kolobok.Stuff;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Social_Tests : BaseTests
    {
        [Ignore]
        [Test]
        public void Social_can_reply()
        {
            var agent = Factory.CreateAgent< IOwner, ISocial >();

            //agent.As<ISocial>().Replies<Colors>(  );
        }

        [Ignore]
        [Test]
        public void Social_answers_it_dont_know_its_hat_color() {}

        [Ignore]
        [Test]
        public void Social_answers_its_hat_color() {}
    }
}