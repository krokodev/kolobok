// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ThinkingProcess_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.Abilities.Thinking.Processes.Imp;
using Robotango.Core.Abilities.Thinking.Rules;
using Robotango.Core.Abilities.Thinking.Rules.Imp;
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

        [Test]
        public void Alice_imagines_Bob()
        {
            var alice = Factory.CreateAgent< IThinking >("Alice");
            var bob = Factory.CreateAgent< IThinking >("Bob");

            alice.As< IThinking >().AddProcess( new ImaginationProcess() );
            var process = alice.As< IThinking >().GetProcess< IImaginationProcess >();

            process.InputReality.AddAgent( bob );

            var dump = Log( alice.Dump() );

            Assert.That( dump, Is.StringContaining( "Alice" ) );
            Assert.That( dump, Is.StringContaining( "<ThinkingAbility>" ) );
            Assert.That( dump, Is.StringContaining( "ImaginationProcess" ) );
            Assert.That( dump, Is.StringContaining( "InnerReality <Reality>" ) );
            Assert.That( dump, Is.StringContaining( "Bob" ) );
        }

        [Test]
        public void Alice_believes_that_Bob_always_presents_in_her_imagination()
        {
            var alice = Factory.CreateAgent< IThinking >("Alice");
            var bob = Factory.CreateAgent< IThinking >("Bob");

            alice.As< IThinking >().AddProcess( new ImaginationProcess() );
            var process = alice.As< IThinking >().GetProcess< IImaginationProcess >();

            process.AddRule( new ExistingRule( bob ) );

            alice.Proceed( null );

            Log( alice.Dump() );

            Assert.That( process.OutputReality.Contains( bob ) );
        }

        [Test]
        public void Process_dump_contains_rules()
        {
            var alice = Factory.CreateAgent< IThinking >("Alice");
            var bob = Factory.CreateAgent< IThinking >("Bob");

            alice.As< IThinking >().AddProcess( new ImaginationProcess() );
            var process = alice.As< IThinking >().GetProcess< IImaginationProcess >();

            process.AddRule( new ExistingRule( bob ) );

            alice.Proceed( null );

            var dump = Log( alice.Dump() );

            Assert.That( dump, Is.StringContaining( "Rules" ) );
            Assert.That( dump, Is.StringContaining( "<ExistingRule>" ) );

            Assert.That( process.OutputReality.Contains( bob ) );
        }

    }
}