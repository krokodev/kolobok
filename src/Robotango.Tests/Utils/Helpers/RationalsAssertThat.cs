// Robotango (c) 2015 Krokodev
// Robotango.Tests
// RationalsAssertThat.cs

using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Tests.Utils.Helpers
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