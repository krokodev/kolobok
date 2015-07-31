// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// World_Tests.cs

using Kolobok.Core.Common;
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

        [Test]
        public void Imaginary_agent_has_the_same_id()
        {
            var alice = Factory.CreateAgent< IRational, IOwner >();
            alice.As< IRational >().Believes( world => world.Add( alice.Clone() ) );
            alice.As< IRational >().Think();
            Log( alice );
            Log( alice.As< IRational >().Imaginary.Agent( alice ) );
            Assert.AreEqual( alice.Id, alice.As< IRational >().Imaginary.Agent( alice ).Id );
        }

        [Test]
        public void Imaginary_agent_has_the_same_name()
        {
            const string name = "Alice";
            var alice = Factory.CreateAgent< IRational, IOwner >( name );
            alice.As< IRational >().Believes( world => world.Add( alice.Clone() ) );
            alice.As< IRational >().Think();
            Log( alice.Name );
            Log( alice.As< IRational >().Imaginary.Agent( alice ).Name );
            Assert.AreEqual( name, alice.Name);
            Assert.AreEqual( alice.Name, alice.As< IRational >().Imaginary.Agent( alice ).Name );
        }

        [Test]
        public void World_has_default_name()
        {
            var world = Factory.CreateAgent<IWorld>().As<IWorld>();
            Log( world );
            Assert.AreEqual( world.Name, Constants.Worlds.DefaultName );
        }

        [Test]
        public void World_name_represent_its_position_in_hierarchy()
        {
            Assert.Ignore("Not implemented");
        }

    }
}