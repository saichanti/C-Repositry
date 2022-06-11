using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class tuple
    {
        public void TupleExp()
        {
            var employee= new Tuple<string, string, string, int>("Sai", "kumar", "dot.net Developer", 2021);
            Console.WriteLine("First Name=" + employee.Item1);
            Console.WriteLine("Last Nmae= " + employee.Item2);
            Console.WriteLine("Designation = " + employee.Item3);
            Console.WriteLine("Year= " + employee.Item4);

        }
    }
}
