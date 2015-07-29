// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// RationalsAssertThat.cs

using Kolobok.Core.Types;

namespace Kolobok.Asserts
{
    public class RationalsAssertThat
    {
        public static void Rational_can_think( IAgent agent )
        {
            var r = agent.GetComponent< IRational >();
            r.Think();
        }
    }
}