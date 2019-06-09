using AristrocratCodeChallenge.Data;
using AristrocratCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.IO;
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


            //prints to the console
            PrintEmployeeByCompanyConsole(employees);

            //prints to the output.txt file in AristocratCodeChallenge/bin/Debug
            PrintEmployeeByCompanyTxt(employees);

            //"Pause" function is included in order to view the results of the information printed to the console
            Pause();
        }
        public static void PrintEmployeeByCompanyConsole(List<Employee> employees)
        {
            //writes each line to the console with formatting
            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Position");
            foreach (Employee e in employees)
            {
                Console.WriteLine("{0,-20} {1,5:N1}", e.Name, e.Position.Description);
            }
        }
        public static void PrintEmployeeByCompanyTxt(List<Employee> employees)
        {
            // Write each employee name and position to the output.txt file with formatting
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                sw.WriteLine("{0,-20} {1,5}\n", "Name", "Position");
                foreach (Employee e in employees)
                {
                    sw.WriteLine("{0,-20} {1,5:N1}", e.Name, e.Position.Description);

                }
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
