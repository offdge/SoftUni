using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var deamons = new Dictionary< string , Dictionary<int, double>>();
            var input = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();

            foreach (var item in input)
            {
                var keyDict = new Dictionary<int, double>();
                var deamonName      = item;
                var health          = Regex.Matches(deamonName, @"[^/\*\d\.+-]") .Cast<Match>().Select(x => (x).ToString()).ToArray();
                var damage          = Regex.Matches(deamonName, @"-*[0-9,\.]+").Cast<Match>().Select(x => double.Parse((x).ToString())).ToArray();
                var doubleSum       = Regex.Matches(deamonName, @"['*']").Cast<Match>().ToArray();
                var divideSum       = Regex.Matches(deamonName, @"['/']").Cast<Match>().ToArray();
                var deamonHealth    = (string.Join("", health)).Select(x => (int)x).Sum();
                var deamonDamage    = ((damage.Select(x => x).Sum())* Math.Pow(2, doubleSum.Length)) / Math.Pow(2, divideSum.Length);

                keyDict.Add(deamonHealth, deamonDamage);
                deamons.Add(deamonName, keyDict);
            }
            var chart = from pair in deamons orderby pair.Key ascending select pair;

            foreach (var deamon in chart)
            {
                var points = deamon.Value.ToList();

                foreach (var point in points)
                {
                    Console.WriteLine("{0} - {1} health, {2:f2} damage", deamon.Key, point.Key, point.Value);
                }
            }
        }
    }
}
