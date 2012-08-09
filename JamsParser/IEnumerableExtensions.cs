using System.Collections.Generic;
using System.Data.Linq;

namespace JamsParser
{
    public static class IEnumerableExtensions
    {
        public static EntitySet<T> ToEntitySet<T>(this IEnumerable<T> enumerable) where T : class
        {
            var set = new EntitySet<T>();
            set.AddRange(enumerable);
            return set;
        }
    }
}