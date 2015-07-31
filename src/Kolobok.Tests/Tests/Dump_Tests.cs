// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Dump_Tests.cs

using Kolobok.Attributes;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Dumps_Tests : BaseTests
    {
        [Test]
        public void Dump_contains_info_about_agents_attributes()
        {
            var universe = Factory.CreateAgent< IWorld >( "Universe" );
            var alice = Factory.CreateAgent< IRational, IEntity >( "Alice" );
            var bob = Factory.CreateAgent< IRational, IEntity >( "Bob" );

            universe.As< IWorld >().Add( alice );
            alice.As< IRational >().Imaginary.Add( bob );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( alice.Clone() );

            IHat aHat = alice.As< IEntity >().Add< Hat >();
            IHat bHat = bob.As< IEntity >().Add< Hat >();

            aHat.Color = Colors.Red;
            bHat.Color = Colors.Black;

            var dump = universe.GetDump();

            Log( dump );

            Assert.Ignore();
            Assert.That( dump.Contains( "Universe" ) );
            Assert.That( dump.Contains( "Alice" ) );
            Assert.That( dump.Contains( "Bob" ) );
            Assert.That( dump.Contains( "Hat" ) );
            Assert.That( dump.Contains( "Red" ) );
            Assert.That( dump.Contains( "Black" ) );
        }
    }
}