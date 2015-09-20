// Robotango (c) 2015 Krokodev
// Robotango.Expressions
// Its.cs

using System;
using Robotango.Core.System;

namespace Robotango.Expressions.Terms
{
    public class Its
    {
        public static IVirtualAccessor Virtual {
            get { return new VirtualAccessor(); }
        }

        public static Func< IAgent, IAgent > Self {
            get { return agent => agent; }
        }
    }
}