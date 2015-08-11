// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActivity.cs

using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Elements.Active
{
    public interface IActivity : IResearchable
    {
        string Name { get; }
    }
}