// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Agent_Tests.cs

using NUnit.Framework;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Abilities;
using Robotango.Core.System;
using Robotango.Tests.Base;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class Agent_Tests : BaseTests
    {
        [Test]
        public void Agent_has_default_name()
        {
            var agent1 = Factory.CreateAgent();
            var agent2 = Factory.CreateAgent< IThinking, IVirtual >();
            Log( agent1 );
            Log( agent2 );
            Assert.AreEqual( Settings.Agents.Names.Default, agent1.Name );
            Assert.AreEqual( Settings.Agents.Names.Default, agent2.Name );
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
            Log( "{0}\n{1}", a1.Name, a2.Name );
            Assert.AreEqual( a1.Name, a2.Name );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void Agent_can_not_have_same_abilities()
        {
            Factory.CreateAgent< IThinking >();
            Factory.CreateAgent< IThinking, IThinking >();
            Factory.CreateAgent< IThinking, IThinking, IThinking >();
            Factory.CreateAgent< IThinking, IThinking, IThinking, IThinking >();
            Factory.CreateAgent< IThinking, IThinking, IThinking, IThinking, IThinking >();
            Factory.CreateAgent< IThinking, IThinking, IThinking, IThinking, IThinking, IThinking >();
            Factory.CreateAgent< IThinking, IThinking, IThinking, IThinking, IThinking, IThinking, IThinking >();
        }
    }
}