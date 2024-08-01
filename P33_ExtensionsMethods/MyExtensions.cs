using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_ExtensionsMethods
{
    internal static class MyExtensions
    {
        public static bool IsPositive(this int value)
        {
            return value > 0;
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool IsGreaterThan(this int value, int otherValue)
        {
            return value > otherValue;
        }

        public static bool HasSpace(this string value)
        {
            return value.Contains(" ");
        }

        public static string ConvertToEmail(this string fullName, int yearOfBirth, string domain)
        {
            string email = $"{string.Join("", fullName.Split(' ')).ToLower()}{yearOfBirth}@{domain}";
            return email;
        }

        public static List<T> FindAndReturnIfEqual<T>(this List<T> list, T value)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (item.Equals(value))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i += 2)
            {
                result.Add(list[i]);
            }
            return result;
        }

        //nepavyktų, nes File klasė yra static

    }
}
