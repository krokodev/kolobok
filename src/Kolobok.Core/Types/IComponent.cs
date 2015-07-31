// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IComponent.cs

namespace Kolobok.Core.Types
{
    public interface IComponent
    {
        void Init( IComposition composition );
        IComponent Clone();
    }
}