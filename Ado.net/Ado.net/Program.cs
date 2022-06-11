using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
           accountdetails accountData = new accountdetails();
            string result2 = accountData.InsertAccount();
            Console.WriteLine(result2);

            employeedetails employeeData = new employeedetails();
                string result1 = employeeData.InsertEmployee();
                Console.WriteLine(result1);

                Customerdetails customerData = new Customerdetails();
                   string result = customerData.InsertCustomer();
                   Console.WriteLine(result);

                

               

                Console.ReadLine();
            }
        }
    }

