// Robotango (c) 2015 Krokodev
// Robotango.Tests
// RationalsAssertThat.cs

using Robotango.Core.Abilities;
using Robotango.Core.Agency;

namespace Robotango.Tests.Common.Helpers
{
    public class ThinkingsAssertThat
    {
        public static void Thinking_can_think( IAgent agent )
        {
            var r = agent.As< IThinking >();
            r.ImplementBeliefs();
        }
    }
}