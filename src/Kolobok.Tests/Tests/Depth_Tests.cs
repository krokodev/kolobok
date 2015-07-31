// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Depth_Tests.cs

using Kolobok.Core.Common;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Depth_Tests : BaseTests
    {
        [Test]
        public void World_has_default_name()
        {
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            Log( world );
            Assert.AreEqual( Constants.Worlds.Names.Default, world.GetName() );
        }

        [Test]
        public void World_has_depth()
        {
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            Assert.AreEqual( Constants.Depth.Basic, world.GetDepth() );
        }

        [Test]
        public void World_agents_have_the_same_depts()
        {
            var matrix = Factory.CreateAgent< IRational >( "Matrix" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            matrix.As< IRational >().Imaginary.Add( alice );
            matrix.As< IRational >().Imaginary.Add( bob );

            Assert.AreEqual( matrix.GetDepth() + 1, matrix.As< IRational >().Imaginary.GetDepth() );
            Assert.AreEqual( matrix.As< IRational >().Imaginary.GetDepth(), alice.GetDepth() );
            Assert.AreEqual( matrix.As< IRational >().Imaginary.GetDepth(), bob.GetDepth() );
        }

        [Test]
        public void Agent_has_depth()
        {
            var agent = Factory.CreateAgent< IRational >();
            Assert.AreEqual( Constants.Depth.Basic, agent.GetDepth() );
        }

        [Test]
        public void Agent_Imaginary_world_has_depth_plus_1()
        {
            var agent = Factory.CreateAgent< IRational >();
            var iworld = agent.As< IRational >().Imaginary;
            Assert.AreEqual( agent.GetDepth() + 1, iworld.GetDepth() );
        }

        [Test]
        public void Cloned_agent_has_basic_depth()
        {
            var matrix = Factory.CreateAgent< IRational >( "Matrix" );
            var agent = Factory.CreateAgent();
            matrix.As< IRational >().Imaginary.Add( agent );
            Assert.AreEqual( 1, agent.GetDepth());
            Assert.AreEqual( Constants.Depth.Basic, agent.Clone().GetDepth());
        }
    }
}