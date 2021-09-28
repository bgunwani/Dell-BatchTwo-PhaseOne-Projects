/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    class Person
    {
        private int _personId;
        private string _personName;
        private int _personAge;
        public string PersonCity { get; set; }

        public int PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }
        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }
        public int PersonAge
        {
            get { return _personAge; }
            set 
            {
                if(value < 18)
                {
                    //throw new Exception("Invalid Age");
                    Console.WriteLine("Invalid Age");
                    return;
                }
                _personAge = value;
            }
        }


    }
    class PropertiesExample
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PersonId = 1001; // Setting Value
            person.PersonName = "Gautam";   // Setting Value
            person.PersonAge = 12;
            Console.WriteLine("Person Id : " + person.PersonId);    // Getting Value
            Console.WriteLine("Person Name : " + person.PersonName);    // Getting Value
            Console.WriteLine("Person Age : " + person.PersonAge);    // Getting Value

            Console.ReadKey();
        }
    }
}
*/