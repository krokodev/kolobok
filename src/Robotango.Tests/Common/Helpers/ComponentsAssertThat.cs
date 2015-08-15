// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ComponentsAssertThat.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Abilities;
using Robotango.Core.Agency;

namespace Robotango.Tests.Common.Helpers
{
    public class ComponentsAssertThat
    {
        public static void Is_ability( IComponent thinking )
        {
            Assert.IsInstanceOf< IAbility >( thinking );
        }

        public static void Has_Thinking_and_social_components( IComposite composite )
        {
            Assert.That( composite.HasComponent< IThinking >() );
            Assert.IsNotNull( composite.HasComponent< ICommunicative >() );
        }
    }
}