// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// AssertThat.cs

using Kolobok.Core.Types;
using NUnit.Framework;

namespace Kolobok.Utils
{
    internal static class AssertThat
    {
        public static void Is_component( IRational rational )
        {
            Assert.IsInstanceOf< IComponent >( rational );
        }

        public static void Has_rational_and_social_components( IAgent agent )
        {
            Assert.IsNotNull( agent.GetComponent< IRational >() );
            Assert.IsNotNull( agent.GetComponent< ISocial >() );
        }
    }
}