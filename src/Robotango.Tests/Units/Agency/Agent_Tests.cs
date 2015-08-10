// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Agent_Tests.cs

using NUnit.Framework;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.System;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class Agent_Tests : BaseTests
    {
        [Test]
        public void Agent_has_default_name()
        {
            var agent1 = Factory.CreateAgent();
            var agent2 = Factory.CreateAgent< IThinking, IVirtual >();
            Log( agent1 );
            Log( agent2 );
            Assert.AreEqual( Settings.Agents.Names.Default, agent1.Name );
            Assert.AreEqual( Settings.Agents.Names.Default, agent2.Name );
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

        [Test, ExpectedException( typeof( AssertException ) )]
        public void Agent_can_not_be_moved_to_another_reality()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world = Factory.CreateReality();
            var newWorld = Factory.CreateReality();
            world.AddAgent( agent );
            agent.Reality = newWorld;
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void Agent_reality_can_not_be_assigned_to_the_arbitrary_world()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world = Factory.CreateReality();
            agent.Reality = world;
        }

        [Test]
        public void Cloned_agent_has_no_reality()
        {
            var world = Factory.CreateReality();
            var agent = world.AddAgent( Factory.CreateAgent< IThinking >() );
            Assert.AreEqual( world, agent.Reality );
            Assert.AreEqual( null, agent.Clone().Reality );
        }

        [Test]
        public void Agents_full_name_describes_its_hierarchy()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = universe.AddAgent( Factory.CreateAgent< IThinking >( "Alice" ) );
            var bob = alice.As< IThinking >().InnerReality.AddAgent( Factory.CreateAgent( "Bob" ) );

            Log( universe.FullName );
            Log( alice.FullName );
            Log( bob.FullName );

            Assert.AreEqual( "Universe", universe.FullName );
            Assert.AreEqual( "Universe[Alice]", alice.FullName );
            Assert.AreEqual( "Universe[Alice].InnerReality[Bob]", bob.FullName );
        }

        [Test]
        public void If_agent_chahge_name_then_imaginary_has_proper_holder_name()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            alice.Name = "New Alice";

            Log( alice.FullName );
            Log( alice.As< IThinking >().InnerReality.FamilyName );

            Assert.AreEqual( "New Alice", alice.Name );
            Assert.AreEqual( "New Alice", alice.As< IThinking >().InnerReality.Holder.Name );
        }

        [Test]
        public void Cloned_agent_imaginary_has_proper_holder()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var clone = alice.Clone();
            clone.Name = "Clone";

            Log( clone );
            Log( clone.As< IThinking >().InnerReality.Holder );

            Assert.AreEqual( "Clone", clone.Name );
            Assert.AreEqual( clone, clone.As< IThinking >().InnerReality.Holder );
        }

        [Test]
        public void Cloned_agent_imaginary_has_proper_holder_name()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var clone = alice.Clone();

            clone.Name = "Clone";

            Log( clone.FullName );
            Log( clone.As< IThinking >().InnerReality.FamilyName );

            Assert.AreEqual( "Clone", clone.Name );
            Assert.AreEqual( "Clone", ( ( IAgent ) clone.As< IThinking >().InnerReality.Holder ).Name );
        }

        [Test]
        public void Cloned_and_inserted_agent_imaginary_has_proper_family_name()
        {
            var world = Factory.CreateReality( "World" );
            var alice = Factory.CreateAgent< IThinking >( "Alice" );

            var clone = alice.Clone();
            clone.Name = "Clone";

            world.AddAgent( clone );

            Log( clone.FullName );
            Log( clone.As< IThinking >().InnerReality.FamilyName );

            Assert.AreEqual( "Clone", clone.Name );
            Assert.AreEqual( 0, clone.Depth );
            Assert.AreEqual( "Clone'0.InnerReality", clone.As< IThinking >().InnerReality.FamilyName );
        }

        [Test]
        public void Thinked_out_cloned_agent_imaginary_has_proper_family_name()
        {
            var bob = Factory.CreateAgent< IThinking >( "Bob" );
            var charly = Factory.CreateAgent< IThinking >( "Charly" );

            bob.As< IThinking >().AddBelief( iworld => iworld.AddAgent( charly.Clone() ) );
            bob.As< IThinking >().Think();

            var bcharly = bob.As< IThinking >().InnerReality.GetAgent( charly );
            bcharly.Name = "bCharly";

            Log( bcharly.FullName );
            Log( bcharly.As< IThinking >().InnerReality.FamilyName );

            Assert.AreEqual( "bCharly", bcharly.Name );
            Assert.AreEqual( 1, bcharly.Depth );
            Assert.AreEqual( "bCharly'1.InnerReality", bcharly.As< IThinking >().InnerReality.FamilyName );
        }
    }
}