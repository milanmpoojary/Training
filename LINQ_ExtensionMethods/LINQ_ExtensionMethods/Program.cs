using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Ghent", "London", "Las Vegas", "Hyderabad" };
            IEnumerable<string> query = cities.Filter(StringThatStartWithL);
                foreach( var city in cities)
            {
                Console.WriteLine(city);
            }
        }
        static bool StringThatStartWithL( string s)
        {
            return s.StartsWith("L");
        }
    }
}
namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T>
            (
            this IEnumerable<T> input, FilterDelegate<T> predicate)
        {
            foreach(var item in input)
            {
                if (predicate(item))
                {
                    yield return item;

                }
            }
        }
    }
    public delegate bool FilterDelegate<T>(T item);
}
