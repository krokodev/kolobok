// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActivity.cs

using Robotango.Common.Types.Types;

namespace Robotango.Core.System
{
    public interface IActivity : IResearchable
    {
        string Name { get; }
        void Execute( IAgent agent, object arg );
    }
}