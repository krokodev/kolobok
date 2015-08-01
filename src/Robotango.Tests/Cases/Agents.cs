// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Agents.cs

using NUnit.Framework;
using Robotango.Core.Common;
using Robotango.Core.Diagnostics;
using Robotango.Core.Types;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Skills;
using Robotango.Tests.Utils;

namespace Robotango.Tests.Cases
{
    [TestFixture]
    public class Agents : BaseCase
    {
        [Test]
        public void Agent_has_default_name()
        {
            var agent1 = Factory.CreateAgent();
            var agent2 = Factory.CreateAgent< IRational, IEntity >();
            Log( agent1 );
            Log( agent2 );
            Assert.AreEqual( Constants.Agents.Names.Default, agent1.Name );
            Assert.AreEqual( Constants.Agents.Names.Default, agent2.Name );
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

        [Test, ExpectedException( typeof( RobotangoException ) )]
        public void Agent_can_not_be_moved_to_another_reality()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            var newWorld = Factory.CreateAgent< IWorld >().As< IWorld >();
            world.Add( agent );
            agent.Reality = newWorld;
        }

        [Test, ExpectedException( typeof( RobotangoException ) )]
        public void Agent_reality_can_not_be_assigned_to_the_arbitrary_world()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            agent.Reality = world;
        }

        [Test]
        public void Cloned_agent_has_no_reality()
        {
            var agent = Factory.CreateAgent< IRational >();
            var world = Factory.CreateAgent< IWorld >().As< IWorld >();
            world.Add( agent );
            Assert.AreEqual( world, agent.Reality );
            Assert.AreEqual( null, agent.Clone().Reality );
        }

        [Test]
        public void Agents_full_name_describes_its_hierarchy()
        {
            var universe = Factory.CreateAgent< IWorld >( "Universe" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var bob = Factory.CreateAgent( "Bob" );
            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );

            Log( universe.FullName );
            Log( alice.FullName );
            Log( bob.FullName );

            Assert.AreEqual( "Universe", universe.FullName );
            Assert.AreEqual( "Universe[Alice]", alice.FullName );
            Assert.AreEqual( "Universe[Alice].Img[Bob]", bob.FullName );
        }

        [Test]
        public void If_agent_chahge_name_then_imaginary_has_proper_holder_name()
        {
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            alice.Name = "New Alice";

            Log( alice.FullName );
            Log( alice.As< IRational >().Imaginary.FamilyName );

            Assert.AreEqual( "New Alice", alice.Name );
            Assert.AreEqual( "New Alice", alice.As< IRational >().Imaginary.Holder.Name );
        }

        [Test]
        public void Cloned_agent_imaginary_has_proper_holder()
        {
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var clone = alice.Clone();
            clone.Name = "Clone";

            Log( clone );
            Log( clone.As< IRational >().Imaginary.Holder );

            Assert.AreEqual( "Clone", clone.Name );
            Assert.AreEqual( clone, clone.As< IRational >().Imaginary.Holder );
        }

        [Test]
        public void Cloned_agent_imaginary_has_proper_holder_name()
        {
            var alice = Factory.CreateAgent< IRational >( "Alice" );
            var clone = alice.Clone();

            clone.Name = "Clone";

            Log( clone.FullName );
            Log( clone.As< IRational >().Imaginary.FamilyName );

            Assert.AreEqual( "Clone", clone.Name );
            Assert.AreEqual( "Clone", ( ( IAgent ) clone.As< IRational >().Imaginary.Holder ).Name );
        }

        [Test]
        public void Cloned_and_inserted_agent_imaginary_has_proper_family_name()
        {
            var world = Factory.CreateAgent< IWorld >( "World" );
            var alice = Factory.CreateAgent< IRational >( "Alice" );

            var clone = alice.Clone(); //world.As< IWorld >().Agent( alice );
            clone.Name = "Clone";

            world.As< IWorld >().Add( clone );

            Log( clone.FullName );
            Log( clone.As< IRational >().Imaginary.FamilyName );

            Assert.AreEqual( "Clone", clone.Name );
            Assert.AreEqual( 0, clone.Depth );
            Assert.AreEqual( "Clone'0.Img", clone.As< IRational >().Imaginary.FamilyName );
        }

        [Test]
        public void Thinked_out_cloned_agent_imaginary_has_proper_family_name()
        {
            var bob = Factory.CreateAgent< IRational >( "Bob" );
            var charly = Factory.CreateAgent< IRational >( "Charly" );

            bob.As< IRational >().Believes( iworld => iworld.Add( charly.Clone() ) );
            bob.As< IRational >().Think();

            var bcharly = bob.As< IRational >().Imaginary.Agent( charly );
            bcharly.Name = "bCharly";

            Log( bcharly.FullName );
            Log( bcharly.As< IRational >().Imaginary.FamilyName );

            Assert.AreEqual( "bCharly", bcharly.Name );
            Assert.AreEqual( 1, bcharly.Depth );
            Assert.AreEqual( "bCharly'1.Img", bcharly.As< IRational >().Imaginary.FamilyName );
        }
    }
}