// Robotango (c) 2015 Krokodev
// Robotango.Core
// Set.cs

namespace Robotango.Core.Expressions
{
    public class Set
    {
        public static IVirtualAccessor Virtual
        {
            get { return new VirtualAccessor( Convert.Agent.To.Virtual ); }
        }
    }
}