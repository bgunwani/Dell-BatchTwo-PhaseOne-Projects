using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    [Serializable]
    class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public int Age { get; set; }
    }

    class FileHandlingExampleThree
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "King Kochhar",
                Salary = 12000,
                Age = 23
            };

            // Seralization:
            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream("D:\\data\\data.txt", FileMode.Create, FileAccess.Write);
            //formatter.Serialize(stream, employee);
            //Console.WriteLine("Content Written to the file successfully.");
            //stream.Close();

           

            // Deserialization:
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\data\\data.txt", FileMode.Open, FileAccess.Read);
            Employee empObj = (Employee) formatter.Deserialize(stream);
            Console.WriteLine("{0}, {1}, {2}", empObj.Name, empObj.Salary, empObj.Age);
            stream.Close();



            Console.ReadKey();

        }
    }
}
