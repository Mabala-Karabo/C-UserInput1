using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_UserInput1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompy the user to enter his or her name
            Console.WriteLine("Enter your name: ");
            // read what the user entered and store it in a string named firstName
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter year born in: ");
            //convert the year you were born in into integer and if a non- numeric is entered an error will occour still working on how to fix that
            int year = Convert.ToInt32(Console.ReadLine());
            //calculate age using the year born in
            int age = 2023 - year;
            //console display
            Console.WriteLine("hi " + firstName + " " + lastName + " you are "+ age + " years old");

            //freeze the console
            Console.ReadLine();
        }
    }
}
