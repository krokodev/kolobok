// Robotango (c) 2015 Krokodev
// Robotango.Common
// IProceedable.cs

namespace Robotango.Common.Domain.Types.Properties
{
    public interface IProceedable<T>
    {
        void Proceed( T context);
    }
}