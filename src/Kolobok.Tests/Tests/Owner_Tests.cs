// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Owner_Tests.cs

using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using Kolobok.Stuff;
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
            var alice = Factory.CreateAgent< IOwner >().As< IOwner >();
            var bob = Factory.CreateAgent< IOwner >().As< IOwner >();
            var hat = new Hat();

            alice.Add( hat );
            bob.Add( hat );
        }

        [Test]
        public void Cloned_owners_have_different_properties()
        {
            var agent = Factory.CreateAgent< IOwner >();
            agent.As< IOwner >().Add( new Hat() );
            var clone = agent.Clone();
            var aHat = agent.As< IOwner >().GetFirst< Hat >();
            var cHat = clone.As< IOwner >().GetFirst< Hat >();
            Assert.AreSame( aHat, aHat );
            Assert.AreSame( cHat, cHat );
            Assert.AreNotSame( aHat, cHat );
        }
    }
}