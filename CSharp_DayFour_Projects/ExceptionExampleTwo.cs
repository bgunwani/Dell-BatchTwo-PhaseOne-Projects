/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class ExceptionExampleTwo
    {
        static void Main(string[] args)
        {
            HttpClient client = null;
            try
            {
                client = new HttpClient();
                var result = client.GetStringAsync("https://www.google1.com/").Result;
                Console.WriteLine(result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client?.Dispose();
            }
        }
    }
}
*/