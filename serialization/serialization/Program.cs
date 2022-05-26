using System;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace serialization
{
    class Program
    {
        public static void serializedata()
        {
            string str = "hello this is sai kumar----------------";
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\user.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStreamObj, str);
            fileStreamObj.Close();
        }
        public static void deserializedata()
        {

            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\user.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            string data = "";
            data = (string)formatter.Deserialize(fileStreamObj);
            fileStreamObj.Close();
            Console.WriteLine("Your deserialize data is ..........................");
            Console.WriteLine(data);
        }
        [Serializable]
        class Employee
        {
            public int EmpID;
            public string EmpName;
            public string Address;
            public Employee(int id, string name, string EmpAdd)
            {
                EmpID = id;
                EmpName = name;
                Address = EmpAdd;
            }
        }
        public static void SerializeData1()
        {

            FileStream fileStream1 = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\user1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee str = new Employee(1, "SaiKumar", "Hyderabad");
            formatter.Serialize(fileStream1, str);
            fileStream1.Close();

        }
        public static void DeSerializeData1()
        {
            Employee emp;
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\user1.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            emp = (Employee)formatter.Deserialize(fileStreamObj);
            int id = emp.EmpID;
            string name = emp.EmpName;
            string Empadd = emp.Address;
            fileStreamObj.Close();
            Console.WriteLine("Your deserialize data is ..........................");

            Console.WriteLine("EmpID = " + id);
            Console.WriteLine("Emp Name = " + name);
            Console.WriteLine("Emp Address = " + Empadd);
        }
        [Serializable]
        public class Student
        {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public int marks { get; set; }

        }
        public static void BinarySerialIzation()
        {
            Student student = new Student();
            student.id = 1;
            student.name = "sai";
            student.age = 23;
            student.marks = 2142;
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\student.txt", FileMode.Create);
            BinaryFormatter Formatter = new BinaryFormatter();
            Formatter.Serialize(fileStreamObj, student);
            fileStreamObj.Close();

        }
        public static void BirnaryDeSerialization()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\student.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();
            Student stu = (Student)Formatter.Deserialize(fileStreamObj);
            Console.WriteLine(stu.id);
            Console.WriteLine(stu.name);
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.marks);
            fileStreamObj.Close();
        }
        public static void XmlSerialization()
        {
            Student student1 = new Student();
            student1.id = 1;
            student1.name = "sai ";
            student1.age = 21;
            student1.marks = 35;
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\xmlfile.txt", FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(fileStreamObj, student1);
            fileStreamObj.Close();


        }
        public static void XmlDeSerialization()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\serialization\xmlfile.txt", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            Student student = (Student)xmlSerializer.Deserialize(fileStreamObj);
            Console.WriteLine(student.id);
            Console.WriteLine(student.name);
            Console.WriteLine(student.age);
            Console.WriteLine(student.marks);

        }


        static void Main(string[] args)
        {

            //serializedata();
            // deserializedata();
            // SerializeData1();
            // DeSerializeData1(); 
            //BinarySerialIzation();
            //BirnaryDeSerialization();
            //XmlSerialization();
            XmlDeSerialization();
            Console.ReadLine();
        }
    }
}

