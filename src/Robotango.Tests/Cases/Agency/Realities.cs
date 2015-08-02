// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Realities.cs

using NUnit.Framework;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.System;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Agency
{
    [TestFixture]
    public class Realities : BaseTests
    {
        [Test, ExpectedException( typeof( AssertException ) )]
        public void Agent_belongs_only_one_world()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateReality();
            var image = agent.As< IRational >().Imaginary;

            world.Add( agent );
            image.Add( agent );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void World_contains_each_agent_only_once()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateReality();

            world.Add( agent );
            world.Add( agent );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void World_contains_only_unique_agents()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateReality();

            world.Add( agent.Clone() );
            world.Add( agent.Clone() );
        }

        [Test]
        public void Cloned_worlds_have_different_id()
        {
            var w1 = Factory.CreateReality();
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
            var alice = Factory.CreateAgent< IRational, IVirtual >();
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
            var alice = Factory.CreateAgent< IRational, IVirtual >( name );
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
            var world = Factory.CreateReality();
            Log( world.Name );
            Assert.AreEqual( Settings.Reality.Names.Default, world.Name );
        }

        [Test]
        public void World_has_its_composition_name()
        {
            var world = Factory.CreateReality( "Universe" );
            Log( world.Name );
            Assert.AreEqual( "Universe", world.Name );
        }

        [Test]
        public void World_has_depth()
        {
            var world = Factory.CreateReality();
            Assert.AreEqual( Settings.Depth.Basic, world.Depth );
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
            var universe = Factory.CreateReality( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            universe.Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( alice.Clone() );

            Assert.IsNull( universe.Holder );
            Assert.AreEqual( "Alice", universe.Agent( alice ).As< IRational >().Imaginary.Holder.Name );
            Assert.AreEqual( "Bob",
                universe.Agent( alice ).As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Holder.Name );
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
            var universe = Factory.CreateReality( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            universe.Add( alice );
            alice.As< IRational >().Believes( iworld => iworld.Add( bob.Clone() ) );
            alice.As< IRational >().Think();
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Believes( iworld => iworld.Add( alice.Clone() ) );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Think();

            var uabaWorld = universe
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
            var universe = Factory.CreateReality();
            var alice = Factory.CreateAgent< IRational >();
            var bob = Factory.CreateAgent< IRational >();

            universe.Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( alice.Clone() );

            var aimg = alice.As< IRational >().Imaginary;
            var bimg = bob.As< IRational >().Imaginary;

            Assert.AreEqual( null, universe.Superior );
            Assert.AreEqual( universe, aimg.Superior );
            Assert.AreEqual( aimg, bimg.Superior );
        }

        [Test]
        public void Worlds_full_name_describes_its_hierarchy()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            universe.Add( alice );
            alice.As< IRational >().Believes( iworld => iworld.Add( bob.Clone() ) );
            alice.As< IRational >().Think();
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Believes( iworld => iworld.Add( alice.Clone() ) );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Think();

            var uabaWorld = universe
                .Agent( alice ).As< IRational >().Imaginary
                .Agent( bob ).As< IRational >().Imaginary
                .Agent( alice ).As< IRational >().Imaginary
                ;

            Log( uabaWorld.FullName );

            Assert.AreEqual( "Universe[Alice].Img[Bob].Img[Alice].Img", uabaWorld.FullName );
        }
    }
}