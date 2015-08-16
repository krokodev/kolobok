// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ThinkingProcess_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.Abilities.Thinking.Processes.Imp;
using Robotango.Tests.Base;

namespace Robotango.Tests.Units.Thinking
{
    [TestFixture]
    public class Processes_Tests : BaseTests
    {
        [Test]
        public void Thinking_has_processes()
        {
            var agent = Factory.CreateAgent< IThinking >();

            agent.As< IThinking >().AddProcess( new RationalProcess() );

            var dump = Log( agent.Dump() );

            Assert.That( dump, Is.StringContaining( "<ThinkingAbility>" ) );
            Assert.That( dump, Is.StringContaining( "Processes" ) );
            Assert.That( dump, Is.StringContaining( "<RationalProcess>" ) );
        }

        [Test]
        public void Alice_can_imagine()
        {
            var alice = Factory.CreateAgent< IThinking >("Alice");
            alice.As< IThinking >().AddProcess( new ImaginationProcess() );
            var dump = Log( alice.Dump() );
            Assert.That( dump, Is.StringContaining( "<ImaginationProcess>" ) );
        }

        [Ignore,Test]
        public void Alice_imagine_Bob()
        {
            var alice = Factory.CreateAgent< IThinking >("Alice");
            var bob = Factory.CreateAgent< IThinking >("Bob");

            alice.As< IThinking >().AddProcess( new ImaginationProcess() );
            var process = alice.As< IThinking >().GetProcess< IImaginationProcess >();

            process.InputReality.AddAgent( bob );

            var dump = Log( alice.Dump() );
            Assert.That( dump, Is.StringContaining( "Alice" ) );
            Assert.That( dump, Is.StringContaining( "<ThinkingAbility>" ) );
            Assert.That( dump, Is.StringContaining( "<ImaginationProcess>" ) );
            Assert.That( dump, Is.StringContaining( "Imagination <IReality>" ) );
            Assert.That( dump, Is.StringContaining( "Input" ) );
            Assert.That( dump, Is.StringContaining( "Output" ) );
            Assert.That( dump, Is.StringContaining( "Bob" ) );
        }

        [Ignore,Test]
        public void Alice_imagines_that_Bob_must_exists()
        {
            var alice = Factory.CreateAgent< IThinking >("Alice");
            var bob = Factory.CreateAgent< IThinking >("Bob");
        }
    }
}