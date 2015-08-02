// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Reflectives.cs

using NUnit.Framework;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Abilities
{
    [TestFixture]
    public class Reflectives : BaseTests
    {
        [Test]
        public void Agent_can_be_reflective()
        {
            var agent = Factory.CreateAgent< IReflective >();
            Assert.That( agent.Is< IReflective >() );
        }
    }
}