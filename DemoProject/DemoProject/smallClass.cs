using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class smallClass

    {
        public string Name;

        public void GetDetails()
        {
            string message = "iam from class1!";

            Console.WriteLine(message);

            int myNum = 667400000;
            Console.WriteLine(myNum);
        }
        public void Details()
        {
            string message =  "class1 is too good";

            Console.WriteLine(message);

            int x = 87, y = 32, z = 65;
            Console.WriteLine(x + y + z);
        }

    }
}
