// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Components.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Implements.Abilities;
using Robotango.Core.Types.Abilities;
using Robotango.Tests.Utils.Bases;
using Robotango.Tests.Utils.Helpers;

namespace Robotango.Tests.Cases.Agency
{
    [TestFixture]
    public class Components : BaseTests
    {
        [Test]
        public void Thinking_is_a_component()
        {
            IThinking r = new Thinking();
            ComponentsAssertThat.Is_component( r );
        }

        [Test]
        public void Factory_creates_composite_agent()
        {
            var r = Factory.CreateComponent< IThinking >();
            var s = Factory.CreateComponent< ICommunicative >();
            var a = Factory.CreateAgent( r, s );
            ComponentsAssertThat.Has_Thinking_and_social_components( a as IComposite );
        }

        [Test]
        public void Factory_conveniently_creates_composite_agent()
        {
            var a = Factory.CreateAgent< IThinking, ICommunicative >();
            ComponentsAssertThat.Has_Thinking_and_social_components( a as IComposite );
        }

        [Test, ExpectedException( typeof( AssertException ) )]
        public void Non_unique_components_cause_exception()
        {
            Factory.CreateAgent< IThinking, IThinking >();
        }
    }
}