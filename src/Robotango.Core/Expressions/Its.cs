// Robotango (c) 2015 Krokodev
// Robotango.Core
// Its.cs

using System;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public class Its
    {
        public static IVirtualAccessor Virtual
        {
            get { return new VirtualAccessor( Convert.Agent.To.Virtual ); }
        }

        public static Func<IAgent,IAgent> Self
        {
            get { return agent => agent; }
        }
    }
}