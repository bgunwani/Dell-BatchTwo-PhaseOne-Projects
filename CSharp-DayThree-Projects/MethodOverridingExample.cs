/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    class Person
    {
        int _personId;
        string _personName;
        public Person(int personId, string personName)
        {
            this._personId = personId;
            this._personName = personName;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Person Id : {0}, Person Name : {1}", 
                this._personId, this._personName);
        }
    }
    class Employee : Person
    {
        float _salary;
        string _designation;
        public Employee(int id, string name, float salary, string designation): base(id, name)
        {
            this._salary = salary;
            this._designation = designation;
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Employee Salary : {0}, Employee Designation : {1}",
                this._salary, this._designation);

        }
    }
    class MethodOverridingExample
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1001, "King Kochhar", 12000, "Manager");
            employee.DisplayDetails();

            Console.ReadKey();
        }
    }
}
*/