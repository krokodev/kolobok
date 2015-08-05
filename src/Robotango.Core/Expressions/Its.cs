// Robotango (c) 2015 Krokodev
// Robotango.Core
// Its.cs

namespace Robotango.Core.Expressions
{
    public class Its
    {
        public static IVirtualAccessor Virtual
        {
            get { return new VirtualAccessor( Convert.Agent.To.Virtual ); }
        }
    }
}