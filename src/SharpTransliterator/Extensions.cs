using System;

namespace SharpTransliterator
{
    internal static class Extensions
    {
        internal static void EnsureHasValue(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentNullException(nameof(s));
            }
        }
    }
}
