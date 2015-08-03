// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Dumps.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Enums;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Domain;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Agency
{
    [TestFixture]
    public class Dumps : BaseTests
    {
        [Test]
        public void Dump_contains_info_about_agents_attributes()
        {
            var universe = Factory.CreateReality( "Universe" );
            var alice = universe.Introduce( Factory.CreateAgent< IThinking, IVirtual >( "Alice" ) );
            var bob = universe.Introduce( Factory.CreateAgent< IThinking, IVirtual >( "Bob" ) );
            var charly = universe.Introduce( Factory.CreateAgent< IThinking, IVirtual >( "Charly" ) );

            alice.As< IThinking >().Imaginary.Introduce( bob.Clone() );
            alice.As< IThinking >().Imaginary.Introduce( charly.Clone() );
            alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Imaginary.Introduce( alice.Clone() );
            alice.As< IThinking >().Imaginary.Agent( bob ).As< IThinking >().Imaginary.Introduce( bob.Clone() );

            alice.As< IVirtual >().Add< Hat >().IHat.Color = Colors.Red;
            bob.As< IVirtual >().Add< Hat >().IHat.Color = Colors.Black;

            var dump = universe.Dump();

            Log( dump );

            Assert.That( dump.Contains( "Universe" ) );
            Assert.That( dump.Contains( "Alice" ) );
            Assert.That( dump.Contains( "Bob" ) );
            Assert.That( dump.Contains( "Charly" ) );

            Assert.That( dump.Contains( "Hat" ) );
            Assert.That( dump.Contains( "Red" ) );
            Assert.That( dump.Contains( "Black" ) );
        }
    }
}