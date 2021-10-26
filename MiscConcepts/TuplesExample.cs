/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    class TuplesExample
    {
        static (int count, int sum) Calculate(IEnumerable<int> values)
        {
            int count = 0;
            int sum = 0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            // Console.WriteLine($"There are {count} values.");
            // Console.WriteLine($"Sum of values : {sum}");
            return (count, sum);
        }
        static void Main(string[] args)
        {
            var values = new List<int>() { 10, 20, 30, 40, 50 };
            var myResult = Calculate(values);
            Console.WriteLine($"There are {myResult.count} values.");
            Console.WriteLine($"Sum of values : {myResult.sum}");
            Console.ReadKey();
        }
    }
}
*/