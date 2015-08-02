﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Projections.cs

using NUnit.Framework;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Agency
{
    [TestFixture]
    public class Projections : BaseTests
    {
        [Test]
        public void World_has_agents_projections()
        {
            var agent = Factory.CreateAgent< IVirtual >( "Alice" );
            var world = Factory.CreateWorld( "The World" );

            world.Reality.Add( agent );
            world.Reality.Clear();
            world.Rational.Think();
            Log( world.Dump() );
            Assert.False( world.Reality.Contains( agent ) );

            world.Reality.Project( agent );
            world.Reality.Clear();
            world.Rational.Think();
            Log( world.Dump() );
            Assert.False( world.Reality.Contains( agent ) );

            world.Reality.Project( agent );
            world.Reality.Clear();
            world.Rational.Believes( reality => reality.Agent( agent ) );
            world.Rational.Think();
            Log( world.Dump() );
            Assert.True( world.Reality.Contains( agent ) );
        }

        [Test]
        public void Projection_is_only_one() {}

        [Test]
        public void Agent_can_be_reprojected_by_another_clone() {}

        [Test]
        public void Alices_has_Bob_projection() {}
    }
}