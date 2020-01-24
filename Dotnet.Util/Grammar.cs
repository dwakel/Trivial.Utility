namespace Dotnet.Util
{
    public static class Grammar
    {
        #region Pluralize
        public static string Pluralize(int count, string singular, string plural = "")
        {
            if (count != 1)
                return plural == "" ? singular + "s" : plural;
            return singular;
            
        }
        public static string Pluralize(double count, string singular, string plural = "")
        {
            if (count != 1)
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
            if (count != 1)
                return plural == "" ? singular + "s" : plural;
            return singular;

        }
        public static string Pluralize(this string singular, double count, string plural = "")
        {
            if (count != 1)
                return plural == "" ? singular + "s" : plural;
            return singular;

        }
        #endregion Pluralize

        #region Singularize
        public static string Singularize(int count, string plural, string singular = "")
        {
            if (count == 1)
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;

        }
        public static string Singularize(double count, string plural, string singular = "")
        {
            if (count == 1)
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
            if (count == 1)
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;

        }
        public static string Singularize(this string plural, double count, string singular = "")
        {
            if (count == 1)
                return singular == "" ? plural.TrimEnd('s') : singular;
            return singular;

        }
        #endregion Singularize

    }
}
