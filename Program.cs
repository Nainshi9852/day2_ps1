using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender (M/F):");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Employee DOJ (dd/mm/yyyy):");
            DateTime doj = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nID\tEmployee Name \tEmployee Gender \tEmployee Salary \tDOJ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t{salary}\t\t{doj.ToString("dd/MM/yyyy")}");

            Console.WriteLine("\nYou have to pay: --------------");

            double taxPercentage = salary > 90000 ? 0.3 : 0.15;
            double taxAmount = salary * taxPercentage;

            Console.WriteLine($"Tax Percentage: {taxPercentage * 100}%");
            Console.WriteLine($"Tax Amount: {taxAmount}");

            Console.ReadLine();
        }
    }
}
