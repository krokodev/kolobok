// Robotango (c) 2015 Krokodev
// Robotango.Core
// IOperation.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Active
{
    public interface IOperation : IResearchable
    {
        void Realize( IReality reality );
        string Name { get; }
        IActivity Activity { get; }
        IAgent Operand { get; }
        object Arg { get; }
    }
}