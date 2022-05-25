using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayHandson
{
    public class array
    {
        int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] names = new string[4] { "Tim", "Martin", "Nikki", "Sara" };
        string[] TureFalse = new string[10];
        public void Array1()
        {
            Console.WriteLine("Numbers---------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("names-------------");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("Ture False-----------------------");
            for (int i = 0; i < TureFalse.Length; i++)
            {
                if (i % 2 == 0)
                {
                    TureFalse[i] = "True";
                }
                else
                {
                    TureFalse[i] = "False";
                }
                Console.WriteLine(TureFalse[i]);

            }

        }
        public void icecreamflavour()
        {
            List<string> icecreamflavours = new List<string>();
            Console.WriteLine("List of ice creame Flavors");
            icecreamflavours.Add("Strawberry.");
            icecreamflavours.Add("Vanilla");
            icecreamflavours.Add("pistha");
            icecreamflavours.Add("Dark Chocolate");
            icecreamflavours.Add("Chocolate");
            icecreamflavours.Add("Mango");
            icecreamflavours.Add("orange");
            foreach (var item in icecreamflavours)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(icecreamflavours.Count);
            Console.WriteLine("---------------------------");
        
        icecreamflavours.RemoveAt(3);
            foreach (var item in icecreamflavours)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(icecreamflavours.Count);







        }


    }
}

