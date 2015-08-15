// Robotango (c) 2015 Krokodev
// Robotango.Core
// IIntention.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Active;

namespace Robotango.Core.Elements.Purposeful
{
    public interface IIntention : IResearchable
    {
        void Realize( IReality reality );
        IOperation Operation { get; }
    }
}