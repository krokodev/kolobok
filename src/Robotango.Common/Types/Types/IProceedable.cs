// Robotango (c) 2015 Krokodev
// Robotango.Common
// IProceedable.cs

namespace Robotango.Common.Types.Types
{
    // Todo:> Remove argument
    public interface IProceedable<in T>
    {
        void Proceed( T context );
    }
}