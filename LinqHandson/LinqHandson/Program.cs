using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quations questions = new Quations();
            Students students = new Students();
            Persons persons = new Persons();
            Console.WriteLine("**************Program 3 ***********************");
            questions.FrequencyOfCharacter();
            Console.WriteLine("**************Program 1 ***********************");
            questions.positivenumbers();
           
            Console.WriteLine("**************Program 5 ***********************");
            Console.WriteLine("Please enter numbers");
            int nth = Convert.ToInt32(Console.ReadLine());
            questions.NthNumber(nth);
           
            Console.WriteLine("**************Program 6 ***********************");
            students.NthMaximumGradePoint();
            Console.WriteLine("**************Program 4 ***********************");
            Console.WriteLine("Enter  Starting Character");
            string start = Console.ReadLine();
            Console.WriteLine("Enter  Ending Character ");
            string end = Console.ReadLine();
            questions.SpecificCharacter(start, end);
            Console.WriteLine();
            Console.WriteLine("**************Program 7 8 9 ***********************");
            persons.startsletterD('D');
            Console.WriteLine("**************Program 2 ***********************");
            questions.FrequencyOfNumber();
            Console.WriteLine("**************Program 10 ***********************");
            questions.startletterL();
            Console.WriteLine("**************Program 11 ***********************");
            questions.multiples4or6();
        }
    }
}
