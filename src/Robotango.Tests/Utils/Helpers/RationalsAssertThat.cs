// Robotango (c) 2015 Krokodev
// Robotango.Tests
// ThinkingsAssertThat.cs

using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Tests.Utils.Helpers
{
    public class ThinkingsAssertThat
    {
        public static void Thinking_can_think( IAgent agent )
        {
            var r = agent.As< IThinking >();
            r.Think();
        }
    }
}