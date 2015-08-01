// Robotango (c) 2015 Krokodev
// Robotango.Core
// IWorld.cs

using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Common;

namespace Robotango.Core.Types.Skills
{
    public interface IWorld : ISkill, IIdentifiable, IResearchable
    {
        IAgent Agent( IAgent agent );
        void Add( params IAgent[] agents );
        IWorld Clone( IAgent holder = null );
        bool Contains( IAgent agent );
        void Clear();
        uint Depth { get; }
        string Name { get; }
        string FullName { get; }
        string FamilyName { get; }
        IAgent Holder { get; }
        IWorld Superior { get; }
    }
}