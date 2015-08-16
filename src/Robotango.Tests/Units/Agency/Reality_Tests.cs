// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Reality_Tests.cs

using NUnit.Framework;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Abilities;
using Robotango.Core.System;
using Robotango.Tests.Base;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class Reality_Tests : BaseTests
    {
        [Test]
        public void Agent_projections_are_not_the_same()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world1 = Factory.CreateReality();
            var world2 = Factory.CreateReality();
            var proj1 = world1.AddAgent( agent );
            var proj2 = world2.AddAgent( agent );

            Assert.AreEqual( proj1.Id, proj2.Id );
            Assert.AreNotSame( proj1, proj2 );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void World_contains_each_agent_only_once()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world = Factory.CreateReality();

            world.AddAgent( agent );
            world.AddAgent( agent );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void World_contains_only_unique_agents()
        {
            var agent = Factory.CreateAgent< IThinking >();
            var world = Factory.CreateReality();

            world.AddAgent( agent.Clone() );
            world.AddAgent( agent.Clone() );
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
            var w1 = Factory.CreateAgent< IThinking >().As< IThinking >().InnerReality;
            var w2 = w1.Clone();
            Log( "{0}\n{1}", w1.Name, w2.Name );
            Assert.AreEqual( w1.Name, w2.Name );
        }

        [Test]
        public void Imaginary_agent_has_the_same_id()
        {
            var alice = Factory.CreateAgent< IThinking, IVirtual >();
            alice.As< IThinking >().AddBelief( world => world.AddAgent( alice.Clone() ) );
            alice.As< IThinking >().ImplementBeliefs();
            Log( alice );
            Log( alice.As< IThinking >().InnerReality.GetAgent( alice ) );
            Assert.AreEqual( alice.Id, alice.As< IThinking >().InnerReality.GetAgent( alice ).Id );
        }

        [Test]
        public void Imaginary_agent_has_the_same_name()
        {
            const string name = "Alice";
            var alice = Factory.CreateAgent< IThinking, IVirtual >( name );
            alice.As< IThinking >().AddBelief( world => world.AddAgent( alice.Clone() ) );
            alice.As< IThinking >().ImplementBeliefs();
            Log( alice.Name );
            Log( alice.As< IThinking >().InnerReality.GetAgent( alice ).Name );
            Assert.AreEqual( name, alice.Name );
            Assert.AreEqual( alice.Name, alice.As< IThinking >().InnerReality.GetAgent( alice ).Name );
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
    }
}