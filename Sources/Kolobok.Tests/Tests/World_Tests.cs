// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// World_Tests.cs

using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class World_Tests : BaseTests
    {
        [Test, ExpectedException( typeof( KolobokException ) )]
        public void Agent_belongs_only_one_world()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >();
            var image = agent.As< IRational >().Imaginary;

            world.As< IWorld >().Add( agent );
            image.Add( agent );
        }

        [Test, ExpectedException( typeof( KolobokException ) )]
        public void World_contains_each_agent_only_once()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >();

            world.As< IWorld >().Add( agent );
            world.As< IWorld >().Add( agent );
        }

        [Test, ExpectedException( typeof( KolobokException ) )]
        public void World_contains_only_unique_agents()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >();

            world.As< IWorld >().Add( agent.Clone() );
            world.As< IWorld >().Add( agent.Clone() );
        }

        [Test]
        public void Cloned_worlds_have_different_id()
        {
            var w1 = Factory.CreateAgent< IWorld >().As< IWorld >();
            var w2 = w1.Clone();
            Log( "{0}\n{1}", w1.Id, w2.Id );
            Assert.AreNotEqual( w1.Id, w2.Id );
        }
    }
}