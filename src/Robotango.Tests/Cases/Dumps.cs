// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Dumps.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Core.Types.Agency.Abilities;
using Robotango.Tests.Stuff;
using Robotango.Tests.Utils;

namespace Robotango.Tests.Cases
{
    [TestFixture]
    public class Dumps : BaseCase
    {
        [Test]
        public void Dump_contains_info_about_agents_attributes()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = Factory.CreateAgent< IRational, IVirtual >( "Alice" );
            var bob = Factory.CreateAgent< IRational, IVirtual >( "Bob" );
            var charly = Factory.CreateAgent< IRational, IVirtual >( "Charly" );

            universe.Add( alice );
            universe.Add( bob );
            universe.Add( charly );
            alice.As< IRational >().Imaginary.Add( bob.Clone() );
            alice.As< IRational >().Imaginary.Add( charly.Clone() );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( alice.Clone() );
            alice.As< IRational >().Imaginary.Agent( bob ).As< IRational >().Imaginary.Add( bob.Clone() );

            alice.As< IVirtual >().Add< Hat >().IHat.Color = Colors.Red;
            bob.As< IVirtual >().Add< Hat >().IHat.Color = Colors.Black;

            var dump = universe.GetDump();

            Log( dump );

            Assert.That( dump.Contains( "Universe" ) );
            Assert.That( dump.Contains( "Alice" ) );
            Assert.That( dump.Contains( "Bob" ) );
            Assert.That( dump.Contains( "Charly" ) );

            Assert.Ignore();
            Assert.That( dump.Contains( "Hat" ) );
            Assert.That( dump.Contains( "Red" ) );
            Assert.That( dump.Contains( "Black" ) );
        }
    }
}