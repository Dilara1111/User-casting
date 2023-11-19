using System;
using System.Transactions;

namespace User_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.Write("Enter the name of person: ");
                string name = Console.ReadLine();
                Console.Write("Enter the surname of person: ");
                string surname = Console.ReadLine();
                Console.Write("Enter age of person: ");
                byte age;
                while (!byte.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("The data was entered incorrectly");
                }
                Console.Write("Enter the salary: ");
                double salary;
                while (!double.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("The salary was entered incorrectly");
                }
                Employee newEmployee = new Employee(name, surname, age, salary);
                Console.WriteLine($"New employee details: \nName:{newEmployee.Name} Surname:{newEmployee.Surname} Age:{newEmployee.Age} " +
                    $"Salary:{newEmployee.Salary} ID:{newEmployee.Id}");
                Console.WriteLine("If you want to break press --> 0");
                i = int.Parse(Console.ReadLine());
                if ( i == 0 )
                {
                    break;
                }
                i++;
                
            }
        }
    }
}

