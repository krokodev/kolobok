// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Reflective_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities;
using Robotango.Tests.Common.Bases;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Reflective_Tests : BaseTests
    {
        [Test]
        public void Agent_can_be_reflective()
        {
            var agent = Factory.CreateAgent< IReflective >();
            Assert.That( agent.Is< IReflective >() );
        }
    }
}