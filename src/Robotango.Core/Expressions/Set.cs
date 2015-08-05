// Robotango (c) 2015 Krokodev
// Robotango.Core
// Set.cs

namespace Robotango.Core.Expressions
{
    public class Set
    {
        public static IVirtualSetter Virtual
        {
            get { return new VirtualSetter( Convert.Agent.To.Virtual ); }
        }
    }
}