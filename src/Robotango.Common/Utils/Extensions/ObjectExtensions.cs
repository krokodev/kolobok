// Robotango (c) 2015 Krokodev
// Robotango.Common
// ObjectExtensions.cs

namespace Robotango.Common.Utils.Extensions
{
    public static class ObjectExtensions
    {
        public static T CastTo<T>( this T obj ) where T : class
        {
            return obj;
        }
    }
}