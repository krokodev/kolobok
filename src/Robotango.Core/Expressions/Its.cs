// Robotango (c) 2015 Krokodev
// Robotango.Core
// Its.cs

namespace Robotango.Core.Expressions
{
    public class Its
    {
        public static VirtualGetter Virtual
        {
            get { return new VirtualGetter( Convert.Agent.To.Virtual ); }
        }
    }
}