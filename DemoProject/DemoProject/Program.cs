using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            smallClass samllClassObj = new smallClass();
            samllClassObj.GetDetails();

            string firstName = "sai ";
            string lastName = "kumar";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 2;
            int y = 9;
            Console.WriteLine(x + y);

            string message = "Hello World!!";

            Console.WriteLine(message);

            smallClass samllClassObj1 = new smallClass();
            samllClassObj1.Details();

           /* Console.WriteLine("Enter username:");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);

            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Your age is: " + age);*/

            int sum1 = 100;
            int sum2 = 250;   
            int sum3 = sum2 + sum2;  
            Console.WriteLine(sum3);
            Console.WriteLine(sum1*sum2);
            Console.WriteLine(sum2-sum1);
        }

        }
    }

