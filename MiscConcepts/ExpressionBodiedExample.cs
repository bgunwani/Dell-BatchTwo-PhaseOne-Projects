using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    class User
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public User(string name) => _name = name;

    }
    class Employee
    {
        private string EmployeeCode;
        private string EmployeeName;
        public Employee(string empCode, string empName)
        {
            this.EmployeeCode = empCode;
            this.EmployeeName = empName;
        }
        
        public override string ToString() => $"Code : {EmployeeCode}, Name : {EmployeeName}";
        public void DisplayDetails() => Console.WriteLine($"Code : {EmployeeCode}, Name : {EmployeeName}");
        
    }
    class ExpressionBodiedExample
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("C001", "King Kochhar");
            employee.DisplayDetails();
            Console.WriteLine(employee);
            Console.ReadKey();
        }
    }
}
