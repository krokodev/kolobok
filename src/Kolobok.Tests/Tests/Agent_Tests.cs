// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Agent_Tests.cs

using Kolobok.Core.Common;
using Kolobok.Core.Diagnostics;
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
            var agent2 = Factory.CreateAgent< IRational, IOwner >();
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
            Log( "{0}\n{1}", a1.Name, a2.Name );
            Assert.AreEqual( a1.Name, a2.Name );
        }

        [Test]
        public void Agent_has_depth()
        {
            var agent = Factory.CreateAgent< IRational >();
            Assert.AreEqual( Constants.BasicDepth, agent.GetDepth() );
        }

        [Test]
        public void Agent_Imaginary_world_has_depth_plus_1()
        {
            var agent = Factory.CreateAgent< IRational >();
            var iworld = agent.As< IRational >().Imaginary;
            Assert.AreEqual( agent.GetDepth() + 1, iworld.GetDepth() );
        }

        [Test, ExpectedException( typeof( KolobokException ) )]
        public void Agent_can_not_be_moved_to_another_reality()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            var newWorld = Factory.CreateAgent< IWorld >().As< IWorld >();
            world.Add( agent );
            agent.Reality = newWorld;
        }

        [Test, ExpectedException( typeof( KolobokException ) )]
        public void Agent_reality_can_not_be_assigned_to_the_arbitrary_world()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            agent.Reality = world;
        }

        [Ignore]
        [Test]
        public void Cloned_agent_has_now_world() {}

        [Ignore]
        [Test]
        public void Cloned_agent_has_basic_depth() {}

        [Test]
        public void Agents_full_name_describes_its_hierarchy()
        {
            Assert.Ignore();
        }
    }
}