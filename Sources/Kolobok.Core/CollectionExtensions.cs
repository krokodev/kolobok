// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// EnumerableUniquenessExtensions.cs

using System.Collections.Generic;
using System.Linq;

namespace Kolobok.Core
{
    internal static class CollectionExtensions
    {
        public static bool IsUnique<T>( this IEnumerable< T > collection )
        {
            return collection.All( new HashSet< T >().Add );
        }
    }
}