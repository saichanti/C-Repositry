using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
            Type t = typeof(string);
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);

           
        }

            class Student
        {

   
            public int RollNo
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

           
            public Student()
            {
                RollNo = 0;
                Name = string.Empty;
            }

           
            public Student(int rno, string n)
            {
                RollNo = rno;
                Name = n;
            }

            public void displayData()
            {
                Console.WriteLine("Roll Number : {0}", RollNo);
                Console.WriteLine("Name : {0}", Name);
            }
        }
       
    }
    }

