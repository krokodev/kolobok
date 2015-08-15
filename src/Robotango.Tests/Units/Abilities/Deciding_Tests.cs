// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Deciding_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities;
using Robotango.Tests.Common.Bases;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class Deciding_Tests : BaseTests
    {
        [Test]
        public void Agent_can_be_deciding()
        {
            var agent = Factory.CreateAgent< IDeciding >();

            var dump = Log( agent.Dump() );

            Assert.That( dump, Is.StringContaining( "<Deciding>" ) );
        }
    }
}