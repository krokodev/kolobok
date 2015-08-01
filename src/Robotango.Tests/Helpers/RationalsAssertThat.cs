// Robotango (c) 2015 Krokodev
// Robotango.Tests
// RationalsAssertThat.cs

using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Components;
using Robotango.Core.Types.Skills;

namespace Robotango.Tests.Helpers
{
    public class RationalsAssertThat
    {
        public static void Rational_can_think( IAgent agent )
        {
            var r = agent.As< IRational >();
            r.Think();
        }
    }
}