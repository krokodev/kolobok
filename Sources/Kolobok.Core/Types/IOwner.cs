// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IOwner.cs

namespace Kolobok.Core.Types
{
    public interface IOwner
    {
        void Has( IProperty property );
        T GetFirst<T>();
    }
}