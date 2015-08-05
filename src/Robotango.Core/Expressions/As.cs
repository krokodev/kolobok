// Robotango (c) 2015 Krokodev
// Robotango.Core
// As.cs

namespace Robotango.Core.Expressions
{
    public static class As
    {
        public static IThinkingExecutor Thinking
        {
            get { return new ThinkingExecutor( Convert.Agent.To.Thinking ); }
        }
    }
}