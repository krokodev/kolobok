// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActivity.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Active
{
    public interface IActivity : IResearchable
    {
        string Name { get; }
        void Execute( IAgent agent, object arg );
    }
}