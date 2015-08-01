// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Depths.cs

using NUnit.Framework;
using Robotango.Core.Common;
using Robotango.Core.Types.Skills;
using Robotango.Tests.Utils;

namespace Robotango.Tests.Cases
{
    [TestFixture]
    public class Depths : BaseCase
    {
        [Test]
        public void World_has_default_name()
        {
            var world = Factory.CreateReality();
            Log( world );
            Assert.AreEqual( Constants.Worlds.Names.Default, world.Name );
        }

        [Test]
        public void World_has_depth()
        {
            var world = Factory.CreateReality();
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
        public void Agent_has_depth()
        {
            var agent = Factory.CreateAgent< IRational >();
            Assert.AreEqual( Constants.Depth.Basic, agent.Depth );
        }

        [Test]
        public void Agent_Imaginary_world_has_depth_plus_1()
        {
            var agent = Factory.CreateAgent< IRational >();
            var iworld = agent.As< IRational >().Imaginary;
            Assert.AreEqual( agent.Depth + 1, iworld.Depth );
        }

        [Test]
        public void Cloned_agent_has_basic_depth()
        {
            var matrix = Factory.CreateAgent< IRational >( "Matrix" );
            var agent = Factory.CreateAgent();
            matrix.As< IRational >().Imaginary.Add( agent );
            Assert.AreEqual( 1, agent.Depth );
            Assert.AreEqual( Constants.Depth.Basic, agent.Clone().Depth );
        }

        [Test]
        public void Inserted_agents_have_proper_depth()
        {
            var universe = Factory.CreateAgent< IRational >( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );
            var charly = Factory.CreateAgent< IRational >( "Charly" );

            universe.As< IRational >().Imaginary.Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            bob.As< IRational >().Imaginary.Add( charly );

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
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );
            var charly = Factory.CreateAgent< IRational >( "Charly" );

            universe.As< IRational >().Imaginary.Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );

            bob.As< IRational >().Believes( iworld => iworld.Add( charly.Clone() ) );
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
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent< IRational >( "Bob" );

            universe.Add( alice );
            alice.As< IRational >().Believes( iworld => iworld.Add( bob.Clone() ) );
            alice.As< IRational >().Think();
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Believes( iworld => iworld.Add( alice.Clone() ) );
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