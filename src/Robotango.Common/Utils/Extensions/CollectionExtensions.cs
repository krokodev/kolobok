// Robotango (c) 2015 Krokodev
// Robotango.Common
// CollectionExtensions.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace Robotango.Common.Utils.Extensions
{
    public static class CollectionExtensions
    {
        public static bool AreUnique<T>( this IEnumerable< T > collection )
        {
            return collection.All( new HashSet< T >().Add );
        }

        public static bool AreUniqueBy<TItem, TValue>( this IEnumerable< TItem > collection, Func< TItem, TValue > selector )
        {
            return collection.Select( selector ).All( new HashSet< TValue >().Add );
        }
    }
}