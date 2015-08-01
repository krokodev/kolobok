// Robotango (c) 2015 Krokodev
// Robotango.Core
// IComponent.cs

namespace Robotango.Core.Types.Compositions
{
    public interface IComponent
    {
        void Init( IComposition composition );
        IComponent Clone();
    }
}