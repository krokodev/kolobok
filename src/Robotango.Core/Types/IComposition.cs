// Robotango (c) 2015 Krokodev
// Robotango.Core
// IComposition.cs

namespace Robotango.Core.Types
{
    public interface IComposition
    {
        T GetComponent<T>( bool nullable = false );
    }
}