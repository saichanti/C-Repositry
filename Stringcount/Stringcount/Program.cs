using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Stringcount
{
    internal class Program
    {
        public  void Stringount()
        {
            Console.WriteLine("Enter the a String");
            string stringcount = Console.ReadLine();

            stringcount = characters(stringcount);

            


        }
        public void File()
        {
            FileStream fileStreamObj = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\CollectionHandsOn\stringfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStreamObj);
            string str = sr.ReadToEnd();
            str = characters(str);
            

            sr.Dispose();
            sr.Close();
            fileStreamObj.Close();


        }
        public string characters(string getstring)
        {


            string str = "";
            getstring = getstring.ToLower();
            char[] chars = getstring.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    str += chars[i].ToString();
                }

            }

            return str;

        }

        public static void Main(string[] args)
        {
          
           
       
        }

    }
}
