using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson
{
    internal class Quations
    {
        public void positivenumbers()
        {
            int[] numbers = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 10, 14 };
            var positive = from number in numbers where number > 0 select number;
            Console.Write("Positive numbers Are:  ");
            foreach (var number in positive)
            {
                Console.WriteLine(number + "  ");
            }

        }
        public void FrequencyOfNumber()
        {
            Console.WriteLine("Number of Integers :");
            int Num = Convert.ToInt32(Console.ReadLine());
            List<int> NumberList = new List<int>();
            for (int i = 1; i <= Num; i++)
            {
                Console.Write((i) + ". Enter Number ");
                NumberList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var numbers in NumberList) 
            {
                Console.WriteLine(numbers);
            }
            
            
            var num = from x in NumberList
                      group x by x into y
                      select y;
            Console.WriteLine("Frequency of number :");
            foreach (var n in num)
            {
                Console.WriteLine("Number " + n.Key + " comes " + n.Count() + " times");
            }
            Console.ReadLine();
        }
        public void FrequencyOfCharacter()
        {
            Console.Write("Enter a String :");
            string str = Console.ReadLine();
       
            var frequency = from x in str
                       group x by x into y
                       select y;
            Console.WriteLine(" Frequency of character :");
            foreach (var n in frequency)
            {
                Console.WriteLine("Character " + n.Key + " comes " + n.Count() + " times");
            }
            Console.ReadLine();
        }
        public void SpecificCharacter(string start, string end)
        {
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            string a = "a";
            var cityWise = from city in cities 
                           where city.StartsWith(start) &&
                           city.EndsWith(end) select city;
            Console.WriteLine("Start with " + start + " and end with " + end);
            foreach (string city in cityWise)
            {
                Console.WriteLine(city);
            }
        }
        public void NthNumber(int nth)
        {
            int[] number = new int[] { 5, 7, 13, 24, 6, 9, 8, 7 };
            var Nth = number.OrderByDescending(n => n).Take(nth);
            Console.WriteLine(" Top " + Nth + "  number is......");
            foreach (var num in Nth)
            {
                Console.WriteLine(num);
            }

        }
        public void startletterL()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var names = fruits.Where(fr => fr.StartsWith("L")).Select(fr => fr);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void multiples4or6()
        {
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var multiple_of_4_6 = mixedNumbers.Where(multiple => multiple % 4 == 0 || multiple % 6 == 0).Select(multiple => multiple);
            foreach (var number in multiple_of_4_6)
            {
                Console.WriteLine(number);
            }
        }

    }
}
