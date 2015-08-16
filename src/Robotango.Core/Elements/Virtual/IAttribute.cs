// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAttribute.cs

using Robotango.Common.Domain.Types;

namespace Robotango.Core.Elements.Virtual
{
    public interface IAttribute : IResearchable
    {
        IAttribute Clone();
        IAttributeHolder Holder { get; set; }
    }
}