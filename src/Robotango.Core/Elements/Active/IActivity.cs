// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActivity.cs

using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public interface IActivity<in T>
    {
        void Run( IAgent operand, T arg );
    }
}