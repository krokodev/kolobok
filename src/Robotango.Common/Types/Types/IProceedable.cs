// Robotango (c) 2015 Krokodev
// Robotango.Common
// IProceedable.cs

namespace Robotango.Common.Types.Types
{
    public interface IProceedable<in T>
    {
        void Proceed( T context );
    }
}