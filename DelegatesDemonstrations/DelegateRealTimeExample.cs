/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemonstrations
{
    public delegate bool EligibleToPromotion(Employee employee);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees, EligibleToPromotion isEmployeeEligible)
        {
            foreach (Employee employee in employees)
            {
                if (isEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted.", employee.Name);
                }
            }
        }
        public static bool Promote(Employee employee)
        {
            if(employee.Salary > 10000) 
            { 
                return true; 
            }
            return false;
        }
    }
    class DelegateRealTimeExample
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { Id = 101, Name = "Kartik", Gender = "Male", Salary = 12000 });
            employeeList.Add(new Employee() { Id = 102, Name = "Karan", Gender = "Male", Salary = 10000 });
            employeeList.Add(new Employee() { Id = 103, Name = "Sumit", Gender = "Male", Salary = 5000 });
            employeeList.Add(new Employee() { Id = 104, Name = "Riya", Gender = "Female", Salary = 7000 });

            EligibleToPromotion eligibleToPromotion = new EligibleToPromotion(Employee.Promote);
            Employee.PromoteEmployee(employeeList, eligibleToPromotion);
            Console.ReadKey();
            

        }
    }
}
*/