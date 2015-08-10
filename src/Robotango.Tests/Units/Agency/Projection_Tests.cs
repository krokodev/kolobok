// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Projection_Tests.cs

using NUnit.Framework;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class Projection_Tests : BaseTests
    {
        [Test]
        public void World_has_agents_projections()
        {
            var agent = Factory.CreateAgent< IVirtual >( "Alice" );
            var world = Factory.CreateWorld( "The World" );

            world.Reality.AddAgent( agent );
            world.Thinking.Think();
            Log( world.Dump() );
            Assert.That( world.Reality.Contains( agent ) );
        }

        [Test]
        public void Projection_is_only_one() {}

        [Test]
        public void Agent_can_be_reprojected_by_another_clone() {}

        [Test]
        public void Alices_has_Bob_projection() {}
    }
}