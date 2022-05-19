using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 


namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilehandlingDemo demo = new FilehandlingDemo();
            demo.UserModule();
            demo.CategoryModule();
            demo.PurchaseandSalesModule();
            demo.ProductModule();
            Console.ReadKey();

        }
     
        
           
    }
}
