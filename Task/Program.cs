using Core.Models;
using System.Collections.Generic;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group gp1 = new();

            Console.WriteLine("Enter the Group Students Limit - [0-20]");

            int limit;
            while (!int.TryParse(Console.ReadLine().Trim(), out limit) || !Group.ValidateStudentLimitField(limit)) {
                continue;

            };

            Console.WriteLine("Enter the Group No - /^[A-Z]{2}\\d{3}$/g");

            string no;
            do
            {
                no = Console.ReadLine();

            }
            while (!Group.ValidateNoField(ref no));

            gp1.StudentLimit = limit;
            gp1.No = no;

            Student std1 = new("Somebody1");
            Student std2 = new("Somebody2");
            Student std3 = new("Somebody3");

            gp1.AddStudent(std1).AddStudent(std2).AddStudent(std3);



        }
    }
}
