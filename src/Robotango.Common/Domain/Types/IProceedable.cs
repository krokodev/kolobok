// Robotango (c) 2015 Krokodev
// Robotango.Common
// IProceedable.cs

namespace Robotango.Common.Domain.Types
{
    public interface IProceedable<in T>
    {
        void Proceed( T context );
    }
}