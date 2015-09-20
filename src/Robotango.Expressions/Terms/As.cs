// Robotango (c) 2015 Krokodev
// Robotango.Expressions
// As.cs

namespace Robotango.Expressions.Terms
{
    public static class As
    {
        public static IThinkingExecutor Thinking {
            get { return new ThinkingExecutor( Convert.Agent.To.Thinking ); }
        }
    }
}