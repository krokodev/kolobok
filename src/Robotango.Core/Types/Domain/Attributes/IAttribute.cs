// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttribute.cs

using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Types.Domain.Attributes
{
    public interface IAttribute : IResearchable
    {
        IAttribute Clone();
        IAttributeHolder Holder { get; set; }
    }
}