using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    public class FilehandlingDemo
    {
        public void UserModule()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\user.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            Console.Write("Enter the UserId: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the FirstName: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the LastName: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the Email: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the Phone: ");
            streamWriterObj.Write(Console.ReadLine());

            streamWriterObj.Close();
            fileStreamObj.Close();

        }
        public void CategoryModule()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\Category.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            Console.Write("Enter the categoryid: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the categorytype: ");
            streamWriterObj.Write(Console.ReadLine());
            
            streamWriterObj.Close();
            fileStreamObj.Close();

        }
    }
    
}
