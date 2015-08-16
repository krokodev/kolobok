// Robotango (c) 2015 Krokodev
// Robotango.Expressions
// Convert.cs

using System;
using Robotango.Core.Abilities.Thinking;
using Robotango.Core.Abilities.Virtual;
using Robotango.Core.System;

namespace Robotango.Expressions.Terms
{
    public static class Convert
    {
        public static class Agent
        {
            public class To
            {
                public static readonly Func< IAgent, IVirtual > Virtual = agent => agent.As< IVirtual >();
                public static readonly Func< IAgent, IThinking > Thinking = agent => agent.As< IThinking >();
            }
        }
    }
}