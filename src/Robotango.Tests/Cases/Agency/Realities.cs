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
        [Test]
        public void Agent_projections_are_not_the_same()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world1 = Factory.CreateReality();
            var world2 = Factory.CreateReality();
            var proj1 = world1.Introduce( agent );
            var proj2 = world2.Introduce( agent );

            Assert.AreEqual( proj1.Id, proj2.Id );
            Assert.AreNotSame( proj1, proj2 );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void World_contains_each_agent_only_once()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world = Factory.CreateReality();

            world.Introduce( agent );
            world.Introduce( agent );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void World_contains_only_unique_agents()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world = Factory.CreateReality();

            world.Introduce( agent.Clone() );
            world.Introduce( agent.Clone() );
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
            var w1 = Factory.CreateAgent< IThinking >().As< IThinking >().Imaginary;
            var w2 = w1.Clone();
            Log( "{0}\n{1}", w1.Name, w2.Name );
            Assert.AreEqual( w1.Name, w2.Name );
        }

        [Test]
        public void Imaginary_agent_has_the_same_id()
        {
            var alice = Factory.CreateAgent< IThinking, IVirtual >();
            alice.As< IThinking >().Believes( world => world.Introduce( alice.Clone() ) );
            alice.As< IThinking >().Think();
            Log( alice );
            Log( alice.As< IThinking >().Imaginary.Agent( alice ) );
            Assert.AreEqual( alice.Id, alice.As< IThinking >().Imaginary.Agent( alice ).Id );
        }

        [Test]
        public void Imaginary_agent_has_the_same_name()
        {
            const string name = "Alice";
            var alice = Factory.CreateAgent< IThinking, IVirtual >( name );
            alice.As< IThinking >().Believes( world => world.Introduce( alice.Clone() ) );
            alice.As< IThinking >().Think();
            Log( alice.Name );
            Log( alice.As< IThinking >().Imaginary.Agent( alice ).Name );
            Assert.AreEqual( name, alice.Name );
            Assert.AreEqual( alice.Name, alice.As< IThinking >().Imaginary.Agent( alice ).Name );
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
            var matrix = Factory.CreateAgent< IThinking >( "Matrix" );
            var alice = matrix.As< IThinking >().Imaginary.Introduce( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = matrix.As< IThinking >().Imaginary.Introduce( Factory.CreateAgent< IThinking >( "Bob" ) );

            Assert.AreEqual( matrix.Depth + 1, matrix.As< IThinking >().Imaginary.Depth );
            Assert.AreEqual( matrix.As< IThinking >().Imaginary.Depth, alice.Depth );
            Assert.AreEqual( matrix.As< IThinking >().Imaginary.Depth, bob.Depth );
        }

        [Test]
        public void Agents_Imaginary_world_has_proper_family_name()
        {
            var bworld = Factory.CreateAgent< IThinking >( "Bob" ).As< IThinking >().Imaginary;
            var alice = bworld.Introduce( Factory.CreateAgent< IThinking >( "Alice" ) );
            var aworld = alice.As< IThinking >().Imaginary;

            Log( bworld.FamilyName );
            Log( aworld.FamilyName );

            Assert.AreEqual( "Alice'1.Imaginary", aworld.FamilyName );
            Assert.AreEqual( "Bob'0.Imaginary", bworld.FamilyName );
        }

        [Test]
        public void Imaginary_worlds_have_holders()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = universe.Introduce( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = alice.As< IThinking >().Imaginary.Introduce( Factory.CreateAgent< IThinking >( "Bob" ) );

            alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Imaginary.Introduce( alice );

            Assert.IsNull( universe.Holder );
            Assert.AreEqual( "Alice", universe.Agent( alice ).As< IThinking >().Imaginary.Holder.Name );
            Assert.AreEqual( "Bob",
                universe.Agent( alice ).As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Imaginary.Holder.Name );
        }

        [Test]
        public void Cloned_agents_Imaginary_has_holder()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var clone = alice.Clone();

            Assert.NotNull( alice.As< IThinking >().Imaginary.Holder );
            Assert.NotNull( clone.As< IThinking >().Imaginary.Holder );
        }

        [Test]
        public void Imaginary_thinked_out_worlds_have_holders()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.As< IThinking >().Believes( iworld => iworld.Introduce( bob.Clone() ) );
            alice.As< IThinking >().Think();

            Assert.NotNull( alice.As< IThinking >().Imaginary.Holder );
            Assert.NotNull( alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Imaginary.Holder );
        }

        [Test]
        public void Wolds_family_name_represents_its_position_in_hierarchy()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = universe.Introduce( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = alice.As< IThinking >().Imaginary.Introduce( Factory.CreateAgent< IThinking >( "Bob" ) );
            var aPrj = alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Imaginary.Introduce( alice );

            alice.As< IThinking >().Think();
            alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Think();

            var uabaWorld = universe
                .Agent( alice ).As< IThinking >().Imaginary
                .Agent( bob ).As< IThinking >().Imaginary
                .Agent( alice ).As< IThinking >().Imaginary
                ;

            Log( uabaWorld.FamilyName );
            Log( uabaWorld.FullName );
            Log( uabaWorld.Superior.FullName );
            Log( uabaWorld.Superior.Superior.FullName );
            Log( uabaWorld.Superior.Superior.Superior.FullName );

            Assert.AreEqual( "Alice'2.Imaginary", uabaWorld.FamilyName );
        }

        [Test]
        public void World_has_superior()
        {
            var universe = Factory.CreateReality();
            var alice = universe.Introduce( Factory.CreateAgent< IThinking >() );
            var bob = alice.As< IThinking >().Imaginary.Introduce( Factory.CreateAgent< IThinking >() );
            alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Imaginary.Introduce( alice );

            var aimg = alice.As< IThinking >().Imaginary;
            var bimg = bob.As< IThinking >().Imaginary;

            Assert.AreEqual( null, universe.Superior );
            Assert.AreEqual( universe, aimg.Superior );
            Assert.AreEqual( aimg, bimg.Superior );
        }

        [Test]
        public void Worlds_full_name_describes_its_hierarchy()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = universe.Introduce( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = alice.As< IThinking >().Imaginary.Introduce( Factory.CreateAgent< IThinking >( "Bob" ) );

            alice.As< IThinking >().Think();
            alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Believes( iworld => iworld.Introduce( alice ) );
            alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Think();

            var uabaWorld = universe
                .Agent( alice ).As< IThinking >().Imaginary
                .Agent( bob ).As< IThinking >().Imaginary
                .Agent( alice ).As< IThinking >().Imaginary
                ;

            Log( uabaWorld.FullName );

            Assert.AreEqual( "Universe[Alice].Imaginary[Bob].Imaginary[Alice].Imaginary", uabaWorld.FullName );
        }
    }
}