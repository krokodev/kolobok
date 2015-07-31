// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Agent_Tests.cs

using Kolobok.Core.Common;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Agent_Tests : BaseTests
    {
        [Test]
        public void Agent_has_default_name()
        {
            var agent1 = Factory.CreateAgent();
            var agent2 = Factory.CreateAgent<IRational, IOwner>();
            Log( agent1 );
            Log( agent2 );
            Assert.AreEqual( Constants.Agents.DefaultName, agent1.Name );
            Assert.AreEqual( Constants.Agents.DefaultName, agent2.Name );
        }

        [Test]
        public void Cloned_agents_have_the_same_ids()
        {
            var a1 = Factory.CreateAgent();
            var a2 = a1.Clone();
            Log( "{0}\n{1}", a1.Id, a2.Id );
            Assert.AreEqual( a1.Id, a2.Id );
        }

        [Test]
        public void Cloned_agents_have_the_same_names()
        {
            var a1 = Factory.CreateAgent( "Alice" );
            var a2 = a1.Clone();
            Log( "{0}\n{1}", a1, a2 );
            Assert.AreEqual( a1.Name, a2.Name );
        }
    }
}