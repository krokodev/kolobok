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
            Assert.AreEqual( Constants.Agents.Names.Default, agent1.Name );
            Assert.AreEqual( Constants.Agents.Names.Default, agent2.Name );
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

        [Test]
        public void Cloned_agent_has_no_reality()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            world.Add( agent );
            Assert.AreEqual( world, agent.Reality );
            Assert.AreEqual( null, agent.Clone().Reality );
        }

        [Test]
        public void Agents_full_name_describes_its_hierarchy()
        {
            var universe = Factory.CreateAgent< IWorld >( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent( "Bob" );
            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            
            Log( universe.GetFullName() );
            Log( alice.GetFullName() );
            Log( bob.GetFullName() );

            Assert.AreEqual( "Universe", universe.GetFullName() );
        }
    }
}