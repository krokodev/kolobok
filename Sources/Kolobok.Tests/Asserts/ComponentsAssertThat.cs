// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// ComponentsAssertThat.cs

using Kolobok.Core.Types;
using NUnit.Framework;

namespace Kolobok.Asserts
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