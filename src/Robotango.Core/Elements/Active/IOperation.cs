// Robotango (c) 2015 Krokodev
// Robotango.Core
// IOperation.cs

using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public interface IOperation
    {
        void Execute( IReality reality );
    }
}