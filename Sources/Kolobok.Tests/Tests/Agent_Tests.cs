// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Agent_Tests.cs

using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Agent_Tests : BaseTests
    {
        [Test]
        public void Cloned_agents_have_the_same_id()
        {
            var a1 = Factory.CreateAgent();
            var a2 = a1.Clone();
            Log( "{0}\n{1}", a1.Id, a2.Id );
            Assert.AreEqual( a1.Id, a2.Id );
        }
    }
}