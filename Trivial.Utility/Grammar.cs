using System.Linq;

namespace Trivial.Utility
{
   public static class Grammar
    {
        #region Pluralize
        public static string Pluralize(int count, string singular, string plural = "")
        {
            if (count != 1 && count != -1)
                return plural == "" ? singular + "s" : plural;
            return singular;
        }
        public static string Pluralize(double count, string singular, string plural = "")
        {
            if (count != 1 && count != -1)
                return plural == "" ? singular + "s" : plural;
            return singular;
        }
        public static string Pluralize(string count, string singular, string plural = "")
        {
            if (!count.ToLower().Equals("one"))
                return plural == "" ? singular + "s" : plural;
            return singular;

        }
        public static string Pluralize(this string singular, int count, string plural = "")
        {
            if (count != 1 && count != -1)
                return plural == "" ? singular + "s" : plural;
            return singular;

        }
        public static string Pluralize(this string singular, double count, string plural = "")
        {
            if (count != 1 && count != -1)
                return plural == "" ? singular + "s" : plural;
            return singular;
        }
        #endregion Pluralize

        #region Singularize
        public static string Singularize(int count, string plural, string singular = "")
        {
            if (count == 1 && count == -1)
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;
        }
        public static string Singularize(double count, string plural, string singular = "")
        {
            if (count == 1 && count == -1)
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;

        }
        public static string Singularize(string count, string plural, string singular = "")
        {
            if (count.ToLower().Equals("one"))
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;

        }
        public static string Singularize(this string plural, int count, string singular = "")
        {
            if (count == 1 && count == -1)
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;

        }
        public static string Singularize(this string plural, double count, string singular = "")
        {
            if (count == 1 && count == -1)
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;

        }
        #endregion Singularize

        #region Checks
        /// <summary>
        /// Check if Word1 and Word2 are anagrams
        /// </summary>
        /// <param name="Word1">string</param>
        /// <param name="Word2"></param>
        /// <returns>True if anagram</returns>
        public static bool IsAnagram(string Word1, string Word2)
        {
            if (Word1.Trim().Length == Word2.Trim().Length)
            {
                var arr = (Word1 + Word2).ToArray();
                var results = arr.GroupBy(x => x)
                    .Select(y => new
                    {
                        number = y.Count()
                    });
                return results.All(x => x.number % 2 == 0);

            }
            return new bool();
        }
        /// <summary>
        /// Check if words are collective anagrams
        /// </summary>
        /// <param name="words">A list of words to check if they are all anagrams</param>
        /// <returns>True if all words are anagrams and false if not</returns>
        public static bool IsAnagram(params string[] words)
        {
            if (words.Sum(x => x.Count()) % words.Length == 0)
            {
                var arr = words.Aggregate((sum, val) => $"{sum}{val}").ToArray();
                var results = arr.GroupBy(x => x)
                    .Select(y => new
                    {
                        number = y.Count()
                    });
                return results.All(x => x.number % 2 == 0);
            }
            return new bool();
        }
        #endregion Checks

    }
}
