// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ComponentsAssertThat.cs

using NUnit.Framework;
using Robotango.Common.Types.Compositions;
using Robotango.Core.Types.Domain.Abilities;
using Robotango.Core.Types.Domain.Agency;

namespace Robotango.Tests.Helpers
{
    public class ComponentsAssertThat
    {
        public static void Is_component( IRational rational )
        {
            Assert.IsInstanceOf< IAbility >( rational );
        }

        public static void Has_rational_and_social_components( IComposite composite )
        {
            Assert.That( composite.HasComponent< IRational >() );
            Assert.IsNotNull( composite.HasComponent< ICommunicative >() );
        }
    }
}