using System;
using System.Collections.Generic;

namespace GreedKataGame.Utility
{
    public static class Contract
    {
        public static void Requires<T>(bool result, string message) where T : Exception
        {
            if (!result)
            {
                throw (T)Activator.CreateInstance(typeof(T), message);
            }
        }

        public static void Requires<T>(bool result, string message, string paramName) where T : Exception
        {
            if (!result)
            {
                throw (T)Activator.CreateInstance(typeof(T), message, paramName);
            }
        }
    }
}
