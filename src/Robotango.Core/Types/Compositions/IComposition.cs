// Robotango (c) 2015 Krokodev
// Robotango.Core
// IComposition.cs

namespace Robotango.Core.Types.Compositions
{
    public interface IComposition
    {
        T GetComponent<T>( bool nullable = false );
    }
}