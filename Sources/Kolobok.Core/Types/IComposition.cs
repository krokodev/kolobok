// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IComposition.cs

namespace Kolobok.Core.Types
{
    public interface IComposition
    {
        T GetComponent<T>(bool nullable=false);
    }
}