using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordClassLibrary;

namespace PasswordConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int length,count;


            Console.Write("Enter length : ");
            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("You haven't entered number !! ");
                Console.Write("Enter length : ");
            }


            Console.Write("Enter count : ");
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("You haven't entered number !! ");
                Console.Write("Enter count : ");
            }

            Console.WriteLine();
            PasswordClassLibrary.PasswordClassLibrary.NewPinCode(length, count);
            Console.ReadKey();
        }
    }
}
