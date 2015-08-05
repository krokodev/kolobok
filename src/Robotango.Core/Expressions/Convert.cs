// Robotango (c) 2015 Krokodev
// Robotango.Core
// Convert.cs

using System;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Expressions
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