// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Attributes.cs

using NUnit.Framework;
using Robotango.Core.Diagnostics;
using Robotango.Core.Types;
using Robotango.Core.Types.Skills;
using Robotango.Tests.Stuff;
using Robotango.Tests.Utils;

namespace Robotango.Tests.Cases
{
    [TestFixture]
    public class Attributes : BaseCase
    {
        [Test, ExpectedException( typeof( RobotangoException ) )]
        public void Entety_cant_have_others_attribute()
        {
            var alice = Factory.CreateAgent< IEntity >().As< IEntity >();
            var bob = Factory.CreateAgent< IEntity >().As< IEntity >();
            var hat = new Hat();

            alice.Add( hat );
            bob.Add( hat );
        }

        [Test]
        public void Cloned_enteties_have_different_attributes()
        {
            var agent = Factory.CreateAgent< IEntity >();
            agent.As< IEntity >().Add( new Hat() );
            var clone = agent.Clone();
            var aHat = agent.As< IEntity >().GetFirst< Hat >();
            var cHat = clone.As< IEntity >().GetFirst< Hat >();
            Assert.AreSame( aHat, aHat );
            Assert.AreSame( cHat, cHat );
            Assert.AreNotSame( aHat, cHat );
        }
    }
}