// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ThinkingProcess_Tests.cs

using NUnit.Framework;
using Robotango.Core.Abilities;
using Robotango.Core.Elements.Thinking;
using Robotango.Core.Elements.Thinking.Imp;
using Robotango.Tests.Base;

namespace Robotango.Tests.Units.Abilities
{
    [TestFixture]
    public class ThinkingProcess_Tests : BaseTests
    {
        [Test]
        public void Thinking_has_processes()
        {
            var agent = Factory.CreateAgent< IThinking >();

            IThinkingProcess process = new RationalProcess();
            agent.As< IThinking >().AddProcess( process );

            var dump = Log( agent.Dump() );

            Assert.That( dump, Is.StringContaining( "<IThinking>" ) );
            Assert.That( dump, Is.StringContaining( "Processes" ) );
            Assert.That( dump, Is.StringContaining( "Rational <ThinkingProcess>" ) );
        }
    }
}