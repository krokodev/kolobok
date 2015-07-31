// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Owner_Tests.cs

using Kolobok.Attributes;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Attributes_Tests : BaseTests
    {
        [Test, ExpectedException( typeof( KolobokException ) )]
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