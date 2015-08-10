// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Depths.cs

using NUnit.Framework;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.System;
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
            var matrix = Factory.CreateAgent< IThinking >( "Matrix" );
            var alice = matrix.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = matrix.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent< IThinking >( "Bob" ) );

            Assert.AreEqual( matrix.Depth + 1, matrix.As< IThinking >().InnerReality.Depth );
            Assert.AreEqual( matrix.As< IThinking >().InnerReality.Depth, alice.Depth );
            Assert.AreEqual( matrix.As< IThinking >().InnerReality.Depth, bob.Depth );
        }

        [Test]
        public void Agent_has_depth()
        {
            var agent = Factory.CreateAgent< IThinking >();
            Assert.AreEqual( Settings.Depth.Basic, agent.Depth );
        }

        [Test]
        public void Agent_Imaginary_world_has_depth_plus_1()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var iworld = agent.As< IThinking >().InnerReality;
            Assert.AreEqual( agent.Depth + 1, iworld.Depth );
        }

        [Test]
        public void Projcted_agent_has_basic_depth()
        {
            var matrix = Factory.CreateAgent< IThinking >( "Matrix" );
            var agent = matrix.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent() );

            Assert.AreEqual( 1, agent.Depth );
            Assert.AreEqual( Settings.Depth.Basic, agent.Clone().Depth );
        }

        [Test]
        public void Inserted_agents_have_proper_depth()
        {
            var universe = Factory.CreateAgent< IThinking >( "Universe" );
            var alice = universe.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = alice.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent< IThinking >( "Bob" ) );
            var charly = bob.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent< IThinking >( "Charly" ) );

            Log( universe.FullName );
            Log( alice.FullName );
            Log( bob.FullName );
            Log( charly.FullName );

            Assert.AreEqual( 0, universe.Depth );
            Assert.AreEqual( 1, alice.Depth );
            Assert.AreEqual( 2, bob.Depth );
            Assert.AreEqual( 3, charly.Depth );

            Assert.AreEqual( 1, universe.As< IThinking >().InnerReality.Agent( alice ).Depth );
            Assert.AreEqual( 2, alice.As< IThinking >().InnerReality.Depth );
            Assert.AreEqual( 2, universe.As< IThinking >().InnerReality.Agent( alice ).As< IThinking >().InnerReality.Depth );
        }

        [Test]
        public void Thinked_out_agent_has_proper_depth()
        {
            var universe = Factory.CreateAgent< IThinking >( "Universe" );
            var alice = universe.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = alice.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent< IThinking >( "Bob" ) );
            var charly = Factory.CreateAgent< IThinking >( "Charly" );

            bob.As< IThinking >().AddBelief( iworld => iworld.AddAgent( charly ) );
            bob.As< IThinking >().Think();

            var bcharly = bob.As< IThinking >().InnerReality.Agent( charly );
            bcharly.Name = "bCharly";

            Log( universe.FullName );
            Log( alice.FullName );
            Log( bob.FullName );
            Log( charly.FullName );
            Log( bcharly.FullName );
            Log( bob.As< IThinking >().InnerReality.FamilyName );
            Log( bcharly.As< IThinking >().InnerReality.FamilyName );

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
            var alice = universe.AddAgent( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.As< IThinking >().AddBelief( iworld => iworld.AddAgent( bob ) );
            alice.As< IThinking >().Think();
            alice.As< IThinking >().InnerReality.Agent( bob ).As< IThinking >().AddBelief( iworld => iworld.AddAgent( alice ) );
            alice.As< IThinking >().InnerReality.Agent( bob ).As< IThinking >().Think();

            Log( universe
                .Agent( alice ).FullName
                );
            Log( universe
                .Agent( alice ).As< IThinking >().InnerReality
                .Agent( bob ).FullName
                );
            Log( universe
                .Agent( alice ).As< IThinking >().InnerReality
                .Agent( bob ).As< IThinking >().InnerReality
                .Agent( alice ).FullName
                );

            Assert.AreEqual( 0,
                universe
                    .Agent( alice ).Depth
                );
            Assert.AreEqual( 1,
                universe
                    .Agent( alice ).As< IThinking >().InnerReality
                    .Agent( bob ).Depth
                );
            Assert.AreEqual( 2,
                universe
                    .Agent( alice ).As< IThinking >().InnerReality
                    .Agent( bob ).As< IThinking >().InnerReality
                    .Agent( alice ).Depth
                );
        }
    }
}