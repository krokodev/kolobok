// Robotango (c) 2015 Krokodev
// Robotango.Core
// IIntention.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Active
{
    public interface IIntention : IResearchable
    {
        void Realize( IReality reality );
        IActivity Activity { get; }
        IAgent Operand { get; }
        object Arg { get; }
    }
}