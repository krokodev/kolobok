// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ComponentsAssertThat.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Tests.Utils.Helpers
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