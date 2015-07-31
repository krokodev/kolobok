// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IOwner.cs

namespace Kolobok.Core.Types
{
    public interface IOwner
    {
        void Add( IProperty property );
        T GetFirst<T>();
    }
}