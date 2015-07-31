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
    public class Owner_Tests : BaseTests
    {
        [Test, ExpectedException( typeof( KolobokException ) )]
        public void Owner_cant_have_others_stuff()
        {
            var alice = Factory.CreateAgent< IEntity >().As< IEntity >();
            var bob = Factory.CreateAgent< IEntity >().As< IEntity >();
            var hat = new Hat();

            alice.Add( hat );
            bob.Add( hat );
        }

        [Test]
        public void Cloned_owners_have_different_properties()
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