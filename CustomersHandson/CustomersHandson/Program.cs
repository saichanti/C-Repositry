using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customers;

namespace CustomersHandson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerData customersObj = new CustomerData();
            customersObj.EBill(4);
            customersObj.CustomerDetails(5);
            customersObj.AllCustomers();
            Console.ReadLine();
           
           
            }
        }
    }

