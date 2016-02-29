using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;
namespace LINQ_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Ghent", "London", "Las Vegas", "Hyderabad" };
            IEnumerable<string> query = cities.StringsThatStartWith("L");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            DateTime date = new DateTime(2002, 8, 9);
            int daysTillEndOfMonth = date.DaysToEndOfMonth();
            Console.WriteLine(daysTillEndOfMonth);
            Console.ReadKey();
        }
    }
    //static bool StringThatStartWithL(string s)
    //{
    //    return s.StartsWith("L");
    //}

    public static class DateUtilities
        {
            public static int DaysToEndOfMonth(this DateTime date)
            {
                return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
            }
        }
    }


namespace Extensions
{
    public static class FilterExtensions
    {
       public static IEnumerable<string> StringsThatStartWith (this IEnumerable<string> input , string start)
        {
            foreach(var s in input)
            {
                if (s.StartsWith(start))
                {
                    yield return s;
                }
            }
        }
    }
    public delegate bool FilterDelegate<T>(T item);
}
