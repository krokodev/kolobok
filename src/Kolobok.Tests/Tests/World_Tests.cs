// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// World_Tests.cs

using Kolobok.Attributes;
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
        public void Cloned_worlds_have_the_same_name()
        {
            var w1 = Factory.CreateAgent< IRational >().As< IRational >().Imaginary;
            var w2 = w1.Clone();
            Log( "{0}\n{1}", w1.Name, w2.Name );
            Assert.AreEqual( w1.Name, w2.Name );
        }

        [Test]
        public void Imaginary_agent_has_the_same_id()
        {
            var alice = Factory.CreateAgent< IRational, IEntity >();
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
            var alice = Factory.CreateAgent< IRational, IEntity >( name );
            alice.As< IRational >().Believes( world => world.Add( alice.Clone() ) );
            alice.As< IRational >().Think();
            Log( alice.Name );
            Log( alice.As< IRational >().Imaginary.Agent( alice ).Name );
            Assert.AreEqual( name, alice.Name );
            Assert.AreEqual( alice.Name, alice.As< IRational >().Imaginary.Agent( alice ).Name );
        }

        [Test]
        public void World_has_default_name()
        {
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            Log( world.Name );
            Assert.AreEqual( Constants.Worlds.Names.Default, world.Name );
        }

        [Test]
        public void World_has_its_composition_name()
        {
            var world = Factory.CreateAgent< IWorld >( "Universe" ).As< IWorld >();
            Log( world.Name );
            Assert.AreEqual( "Universe", world.Name );
        }

        [Test]
        public void World_has_depth()
        {
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            Assert.AreEqual( Constants.Depth.Basic, world.Depth );
        }

        [Test]
        public void World_agents_have_the_same_depts()
        {
            var matrix = Factory.CreateAgent< IRational >( "Matrix" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            matrix.As< IRational >().Imaginary.Add( alice );
            matrix.As< IRational >().Imaginary.Add( bob );

            Assert.AreEqual( matrix.Depth + 1, matrix.As< IRational >().Imaginary.Depth );
            Assert.AreEqual( matrix.As< IRational >().Imaginary.Depth, alice.Depth );
            Assert.AreEqual( matrix.As< IRational >().Imaginary.Depth, bob.Depth );
        }

        [Test]
        public void Agents_Imaginary_world_has_proper_family_name()
        {
            var bworld = Factory.CreateAgent< IRational >( "Bob" ).As< IRational >().Imaginary;
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var aworld = alice.As< IRational >().Imaginary;
            bworld.Add( alice );

            Log( bworld.FamilyName );
            Log( aworld.FamilyName );

            Assert.AreEqual( "Alice'1.Img", aworld.FamilyName );
            Assert.AreEqual( "Bob'0.Img", bworld.FamilyName );
        }

        [Test]
        public void Imaginary_worlds_have_holders()
        {
            var universe = Factory.CreateAgent< IWorld >( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( alice.Clone() );

            Assert.IsNull( universe.As< IWorld >().Holder );
            Assert.AreEqual( "Alice", universe.As< IWorld >().Agent( alice ).As< IRational >().Imaginary.Holder.Name );
            Assert.AreEqual( "Bob",
                universe.As< IWorld >().Agent( alice ).As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Holder.Name );
        }

        [Test]
        public void Cloned_agents_Imaginary_has_holder()
        {
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var clone = alice.Clone();

            Assert.NotNull( alice.As< IRational >().Imaginary.Holder );
            Assert.NotNull( clone.As< IRational >().Imaginary.Holder );
        }

        [Test]
        public void Imaginary_thinked_out_worlds_have_holders()
        {
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            alice.As< IRational >().Believes( iworld => iworld.Add( bob.Clone() ) );
            alice.As< IRational >().Think();

            Assert.NotNull( alice.As< IRational >().Imaginary.Holder );
            Assert.NotNull( alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Holder );
        }

        [Test]
        public void Thinked_out_worlds_family_name_represents_its_position_in_hierarchy()
        {
            var universe = Factory.CreateAgent< IWorld >( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Believes( iworld => iworld.Add( bob.Clone() ) );
            alice.As< IRational >().Think();
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Believes( iworld => iworld.Add( alice.Clone() ) );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Think();

            var uabaWorld =
                universe.As< IWorld >()
                    .Agent( alice ).As< IRational >().Imaginary
                    .Agent( bob ).As< IRational >().Imaginary
                    .Agent( alice ).As< IRational >().Imaginary
                ;

            Log( uabaWorld.FamilyName );
            Log( uabaWorld.FullName );
            Log( uabaWorld.Superior.FullName );
            Log( uabaWorld.Superior.Superior.FullName );
            Log( uabaWorld.Superior.Superior.Superior.FullName );

            Assert.AreEqual( "Alice'2.Img", uabaWorld.FamilyName );
        }

        [Test]
        public void World_has_superior()
        {
            var universe = Factory.CreateAgent< IWorld >();
            var alice = Factory.CreateAgent< IRational >();
            var bob = Factory.CreateAgent< IRational >();

            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( alice.Clone() );

            var world = universe.As< IWorld >();
            var aimg = alice.As< IRational >().Imaginary;
            var bimg = bob.As< IRational >().Imaginary;

            Assert.AreEqual( null, world.Superior );
            Assert.AreEqual( world, aimg.Superior );
            Assert.AreEqual( aimg, bimg.Superior );
        }

        [Test]
        public void Worlds_full_name_describes_its_hierarchy()
        {
            var universe = Factory.CreateAgent< IWorld >( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Believes( iworld => iworld.Add( bob.Clone() ) );
            alice.As< IRational >().Think();
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Believes( iworld => iworld.Add( alice.Clone() ) );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Think();

            var uabaWorld =
                universe.As< IWorld >()
                    .Agent( alice ).As< IRational >().Imaginary
                    .Agent( bob ).As< IRational >().Imaginary
                    .Agent( alice ).As< IRational >().Imaginary
                ;

            Log( uabaWorld.FullName );

            Assert.AreEqual( "Universe[Alice].Img[Bob].Img[Alice].Img", uabaWorld.FullName );
        }

        [Ignore]
        [Test]
        public void World_dump_contains_info_about_agents_attributes()
        {
            var universe = Factory.CreateAgent< IWorld >();
            var alice = Factory.CreateAgent< IRational, IEntity >();
            var bob = Factory.CreateAgent< IRational, IEntity >();

            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( alice.Clone() );

            var aHat = alice.As< IEntity >().Add< Hat >();
            var bHat = bob.As< IEntity >().Add< Hat >();
            bob.As< IEntity >().Add( new Hat() );
        }
    }
}