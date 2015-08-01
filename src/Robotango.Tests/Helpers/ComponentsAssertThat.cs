// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ComponentsAssertThat.cs

using NUnit.Framework;
using Robotango.Core.Types.Components;
using Robotango.Core.Types.Compositions;
using Robotango.Core.Types.Skills;

namespace Robotango.Tests.Helpers
{
    public class ComponentsAssertThat
    {
        public static void Is_component( IRational rational )
        {
            Assert.IsInstanceOf< IComponent >( rational );
        }

        public static void Has_rational_and_social_components( IComposition composition )
        {
            Assert.IsNotNull( composition.GetComponent< IRational >() );
            Assert.IsNotNull( composition.GetComponent< ISocial >() );
        }
    }
}