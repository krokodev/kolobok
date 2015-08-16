// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Component_Tests.cs

using NUnit.Framework;
using Robotango.Common.Types.Compositions;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Abilities;
using Robotango.Core.Agency;
using Robotango.Tests.Base;

namespace Robotango.Tests.Units.Agency
{
    [TestFixture]
    public class Component_Tests : BaseTests
    {
        [Test]
        public void Thinking_is_a_component()
        {
            var abiity = Factory.CreateComponent< IThinking >();
            Assert.IsInstanceOf< IAbility >( abiity );
        }

        [Test]
        public void Factory_creates_composite_agent()
        {
            var r = Factory.CreateComponent< IThinking >();
            var s = Factory.CreateComponent< ICommunicative >();
            var a = Factory.CreateAgent( r, s );

            Assert.That( ( ( IComposite ) a ).HasComponent< IThinking >() );
            Assert.That( ( ( IComposite ) a ).HasComponent< ICommunicative >() );
        }

        [Test]
        public void Factory_conveniently_creates_composite_agent()
        {
            var a = Factory.CreateAgent< IThinking, ICommunicative >();
            Assert.That( ( ( IComposite ) a ).HasComponent< IThinking >() );
            Assert.That( ( ( IComposite ) a ).HasComponent< ICommunicative >() );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void Non_unique_components_cause_exception()
        {
            Factory.CreateAgent< IThinking, IThinking >();
        }
    }
}