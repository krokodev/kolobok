// Robotango (c) 2015 Krokodev
// Robotango.Core
// Convertors.cs

using System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public static class Convert
    {
        public static class Agent
        {
            public class To
            {
                public static readonly Func< IAgent, IVirtual > Virtual = agent => agent.As< IVirtual >();
            }
        }
    }
}