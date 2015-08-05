// Robotango (c) 2015 Krokodev
// Robotango.Core
// Set.cs

namespace Robotango.Core.Expressions
{
    public class Set
    {
        public static IVirtualAction Virtual
        {
            get { return new VirtualAction( Convert.Agent.To.Virtual ); }
        }
    }
}