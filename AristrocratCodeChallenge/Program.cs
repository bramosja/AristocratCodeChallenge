using AristrocratCodeChallenge.Data;
using AristrocratCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AristrocratCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            List<Employee> employees = repository.GetEmployeeByDepartment(2);

            PrintEmployeeByCompany(employees);
            Pause();
        }
        public static void PrintEmployeeByCompany(List<Employee> employees)
        {
            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Position");
            foreach (Employee e in employees)
            {
                Console.WriteLine("{0,-20} {1,5:N1}", e.Name, e.Position.Description);
            }
        }
            public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
