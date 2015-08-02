// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Depths.cs

using NUnit.Framework;
using Robotango.Core.System;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Depths : BaseTests
    {
        [Test]
        public void World_has_default_name()
        {
            var world = Factory.CreateReality();
            Log( world );
            Assert.AreEqual( Settings.Reality.Names.Default, world.Name );
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
            var alice = matrix.As< IRational >().Imaginary.Introduce( Factory.CreateAgent< IRational >( "Alice" ) );
            var bob = matrix.As< IRational >().Imaginary.Introduce( Factory.CreateAgent< IRational >( "Bob" ) );

            Assert.AreEqual( matrix.Depth + 1, matrix.As< IRational >().Imaginary.Depth );
            Assert.AreEqual( matrix.As< IRational >().Imaginary.Depth, alice.Depth );
            Assert.AreEqual( matrix.As< IRational >().Imaginary.Depth, bob.Depth );
        }

        [Test]
        public void Agent_has_depth()
        {
            var agent = Factory.CreateAgent< IRational >();
            Assert.AreEqual( Settings.Depth.Basic, agent.Depth );
        }

        [Test]
        public void Agent_Imaginary_world_has_depth_plus_1()
        {
            var agent = Factory.CreateAgent< IRational >();
            var iworld = agent.As< IRational >().Imaginary;
            Assert.AreEqual( agent.Depth + 1, iworld.Depth );
        }

        [Test]
        public void Projcted_agent_has_basic_depth()
        {
            var matrix = Factory.CreateAgent< IRational >( "Matrix" );
            var agent = matrix.As< IRational >().Imaginary.Introduce( Factory.CreateAgent() );

            Assert.AreEqual( 1, agent.Depth );
            Assert.AreEqual( Settings.Depth.Basic, agent.Clone().Depth );
        }

        [Test]
        public void Inserted_agents_have_proper_depth()
        {
            var universe = Factory.CreateAgent< IRational >( "Universe" );
            var alice = universe.As< IRational >().Imaginary.Introduce( Factory.CreateAgent< IRational >( "Alice" ) );
            var bob = alice.As< IRational >().Imaginary.Introduce( Factory.CreateAgent< IRational >( "Bob" ) );
            var charly = bob.As< IRational >().Imaginary.Introduce( Factory.CreateAgent< IRational >( "Charly" ) );

            Log( universe.FullName );
            Log( alice.FullName );
            Log( bob.FullName );
            Log( charly.FullName );

            Assert.AreEqual( 0, universe.Depth );
            Assert.AreEqual( 1, alice.Depth );
            Assert.AreEqual( 2, bob.Depth );
            Assert.AreEqual( 3, charly.Depth );

            Assert.AreEqual( 1, universe.As< IRational >().Imaginary.Agent( alice ).Depth );
            Assert.AreEqual( 2, alice.As< IRational >().Imaginary.Depth );
            Assert.AreEqual( 2, universe.As< IRational >().Imaginary.Agent( alice ).As< IRational >().Imaginary.Depth );
        }

        [Test]
        public void Thinked_out_agent_has_proper_depth()
        {
            var universe = Factory.CreateAgent< IRational >( "Universe" );
            var alice = universe.As< IRational >().Imaginary.Introduce( Factory.CreateAgent< IRational >( "Alice" ) );
            var bob = alice.As< IRational >().Imaginary.Introduce( Factory.CreateAgent< IRational >( "Bob" ) );
            var charly = Factory.CreateAgent< IRational >( "Charly" );

            bob.As< IRational >().Believes( iworld => iworld.Introduce( charly ) );
            bob.As< IRational >().Think();

            var bcharly = bob.As< IRational >().Imaginary.Agent( charly );
            bcharly.Name = "bCharly";

            Log( universe.FullName );
            Log( alice.FullName );
            Log( bob.FullName );
            Log( charly.FullName );
            Log( bcharly.FullName );
            Log( bob.As< IRational >().Imaginary.FamilyName );
            Log( bcharly.As< IRational >().Imaginary.FamilyName );

            Assert.AreEqual( 0, universe.Depth );
            Assert.AreEqual( 1, alice.Depth );
            Assert.AreEqual( 2, bob.Depth );
            Assert.AreEqual( 0, charly.Depth );
            Assert.AreEqual( 3, bcharly.Depth );
        }

        [Test]
        public void Deeply_thinked_out_agents_have_proper_depth()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = universe.Introduce( Factory.CreateAgent< IRational >( "Alice" ) );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            alice.As< IRational >().Believes( iworld => iworld.Introduce( bob ) );
            alice.As< IRational >().Think();
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Believes( iworld => iworld.Introduce( alice ) );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Think();

            Log( universe
                .Agent( alice ).FullName
                );
            Log( universe
                .Agent( alice ).As< IRational >().Imaginary
                .Agent( bob ).FullName
                );
            Log( universe
                .Agent( alice ).As< IRational >().Imaginary
                .Agent( bob ).As< IRational >().Imaginary
                .Agent( alice ).FullName
                );

            Assert.AreEqual( 0,
                universe
                    .Agent( alice ).Depth
                );
            Assert.AreEqual( 1,
                universe
                    .Agent( alice ).As< IRational >().Imaginary
                    .Agent( bob ).Depth
                );
            Assert.AreEqual( 2,
                universe
                    .Agent( alice ).As< IRational >().Imaginary
                    .Agent( bob ).As< IRational >().Imaginary
                    .Agent( alice ).Depth
                );
        }
    }
}