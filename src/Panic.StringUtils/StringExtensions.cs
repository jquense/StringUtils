using System.Collections.Generic;

namespace Panic.StringUtils.Extensions
{
    public static class StringExtensions
    {
        public static string StripIndent(this string str)
        {
            return StringUtils.StripIndent(str);
        }

        public static IEnumerable<string> ToWords(this string str)
        {
            return StringUtils.ToWords(str);
        }

        public static string ToUpperFirst(this string str)
        {
            return StringUtils.ToUpperFirst(str);
        }

        public static string ToLowerFirst(this string str)
        {
            return StringUtils.ToLowerFirst(str);
        }

        public static string Capitalize(this string str)
        {
            return StringUtils.Capitalize(str);
        }

        public static string ToCamelCase(this string str)
        {
            return StringUtils.ToCamelCase(str);
        }

        public static string ToConstantCase(this string str)
        {
            return StringUtils.ToConstantCase(str);
        }

        public static string ToUpperCase(this string str)
        {
            return StringUtils.ToUpperCase(str);
        }

        public static string ToLowerCase(this string str)
        {
            return StringUtils.ToLowerCase(str);
        }


        public static string ToPascalCase(this string str)
        {
            return StringUtils.ToPascalCase(str);
        }


        public static string ToKebabCase(this string str)
        {
            return StringUtils.ToKebabCase(str);
        }


        public static string ToSnakeCase(this string str)
        {
            return StringUtils.ToSnakeCase(str);
        }

    }
}
