using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_One
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpin, epin;
            string user = "";


            rpin = ("Bct@1234");

            do
            {
                Console.Write("Enter your Username: ");
                user = Console.ReadLine();
                Console.WriteLine(" ");

                if (user != "Admin")
                {
                    Console.WriteLine("Incorrect Username try again");
                    Console.WriteLine(" ");

                }

            } while (user != "Admin");
            Console.WriteLine("Welcome");

            for (int a = 1; a <= 3; a = a + 1)
            {
                Console.WriteLine(" ");
                Console.Write("Enter Pin: ");
                epin = Console.ReadLine();
                Console.WriteLine(" ");

                if (epin == rpin)
                {
                    Console.WriteLine("Welcome Admin");
                    a = 3;
                    Console.ReadKey();
                    return;
                }

                else
                {
                    Console.WriteLine("Wrong Pin " + a + "/3 Attempts left");
                }

                if (a >= 3)
                {
                    Console.WriteLine("There are no more attempts left, goodbye.");
                    Console.ReadKey();
                }
            }

            
             

        }
    }
}
