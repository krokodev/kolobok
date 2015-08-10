// Robotango (c) 2015 Krokodev
// Robotango.Core
// IIntention.cs

using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Purposeful
{
    public interface IIntention
    {
        void Execute( IReality reality );
    }
}