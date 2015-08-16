// Robotango (c) 2015 Krokodev
// Robotango.Core
// IOperation.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Reality
{
    public interface IOperation : IResearchable
    {
        void Realize( IReality reality );
        IActivity Activity { get; }
        IAgent Operand { get; }
        object Arg { get; }
    }
}