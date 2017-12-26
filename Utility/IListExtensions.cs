using System;
using System.Collections.Generic;

namespace GreedKataGame.Utility
{
    public static class IListExtensions
    {
        public static void AddIfNotNull<T>(this IList<T> source, T value)
        {
            if (value != null)
            {
                source.Add(value);
            }
        }
    }
}
