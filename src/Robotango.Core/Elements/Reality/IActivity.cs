// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActivity.cs

using Robotango.Common.Domain.Types;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Reality
{
    public interface IActivity : IResearchable
    {
        string Name { get; }
        void Execute( IAgent agent, object arg );
    }
}