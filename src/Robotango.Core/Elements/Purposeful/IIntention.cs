// Robotango (c) 2015 Krokodev
// Robotango.Core
// IIntention.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Purposeful
{
    public interface IIntention : IResearchable
    {
        void Execute( IReality reality );
        IOperation Operation {get; }
    }
}