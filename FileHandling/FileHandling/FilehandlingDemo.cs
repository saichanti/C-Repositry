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
        public void PurchaseandSalesModule()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\Purchase_and_Sales_Module.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            Console.Write("Enter the SalesId: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the Productid: ");
            streamWriterObj.Write(Console.ReadLine());
            Console.Write("Enter the price: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the salesdate: ");
            streamWriterObj.Write(Console.ReadLine());

            streamWriterObj.Close();
            fileStreamObj.Close();

        }
        public void ProductModule()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\ProductModule.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            Console.Write("Enter the Productid: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the categorytype: ");
            streamWriterObj.Write(Console.ReadLine());
            Console.Write("Enter the productname: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the quantity: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Write(',');
            Console.Write("Enter the price: ");
            streamWriterObj.Write(Console.ReadLine());
            streamWriterObj.Close();
            fileStreamObj.Close();

        }
        public void NetworkModule()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\NetworkDetails.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.WriteLine("Welcome to training");
            streamWriterObj.Close();
            fileStreamObj.Close();
        }
        public void ReadFile()
        {


            string[] values = { "A", "B", "C", "D", "E", "F", "G" };
            int[] Id = new int[12];
            int[] Sourse = new int[12];
            int[] Destination = new int[12];
            int[] Date = new int[12];
            int[] Time = new int[12];
            string[] Status = new string[12];
            string[] Network = new string[12];
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\NetworkDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            Console.WriteLine("Id\tSourse\t\tDestination\tDate\t\tTime\t\tStatus\tNetwork");

            while (streamReaderObj.Peek() > 0)
            {
                string Details = streamReaderObj.ReadLine();
                if (Details != "")
                {
                    string[] NetworkDetails = Details.Split(':');
                    if (NetworkDetails.Length > 3)
                    {
                        string[] mydateTime = NetworkDetails[1].Split(' ');
                        Console.Write(mydateTime[0] + "\t" + mydateTime[1] + ":" + NetworkDetails[2] + ":" + NetworkDetails[3] + "\t");
                    }
                    else
                    {
                        Console.Write(NetworkDetails[1] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }


        }
        public void Succes()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\NetworkDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            Console.WriteLine("Id\tSourse\t\tDestination\tDate\t\tTime\t\tStatus\tNetwork");
            string[] Status = new string[6];
            while (streamReaderObj.Peek() > 0)
            {
                string Details = streamReaderObj.ReadLine();
                if (Details != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] NetworkDetails = Details.Split(':');
                        if (NetworkDetails.Length > 3)
                        {
                            string[] mydateTime = NetworkDetails[1].Split(' ');
                            Status[i] = mydateTime[0];
                            Status[i + 1] = mydateTime[1] + ":" + NetworkDetails[2] + ":" + NetworkDetails[3];
                            i++;

                        }
                        else
                        {
                            Status[i] = NetworkDetails[1];


                            if (NetworkDetails[1] == "Success")
                            {
                                Console.Write(Status[0] + "\t" + Status[1] + "\t" + Status[2] + "\t" + Status[3] + "\t" +Status[4] + "\t" + Status[5] + "\t");
                                Details = streamReaderObj.ReadLine();
                                string[] network = Details.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(Status, 0, Status.Length);
                                Console.WriteLine();
                            }

                        }
                        Details = streamReaderObj.ReadLine();

                    }
                }
                else
                {

                  

                }

            }


        }
        public void Failed()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\NetworkDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            Console.WriteLine("Id\tSourse\t\tDestination\tDate\t\tTime\t\tStatus\tNetwork");
            string[] Status = new string[6];
            while (streamReaderObj.Peek() > 0)
            {
                string Details = streamReaderObj.ReadLine();
                if (Details != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] NetworkDetails = Details.Split(':');
                        if (NetworkDetails.Length > 3)
                        {
                            string[] mydateTime = NetworkDetails[1].Split(' ');
                            Status[i] = mydateTime[0];
                            Status[i + 1] = mydateTime[1] + ":" + NetworkDetails[2] + ":" + NetworkDetails[3];
                            i++;

                        }
                        else
                        {
                            Status[i] = NetworkDetails[1];


                            if (NetworkDetails[1] == "Failed")
                            {
                                Console.Write(Status[0] + "\t" + Status[1] + "\t" + Status[2] + "\t" + Status[3] + "\t" + Status[4] + "\t" + Status[5] + "\t");
                                Details = streamReaderObj.ReadLine();
                                string[] network = Details.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(Status, 0, Status.Length);
                                Console.WriteLine();
                            }

                        }
                        Details = streamReaderObj.ReadLine();

                    }
                }
                else
                {



                }

            }


        }
        public void Dailled()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\NetworkDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            Console.WriteLine("Id\tSourse\t\tDestination\tDate\t\tTime\t\tStatus\tNetwork");
            string[] Status = new string[6];
            while (streamReaderObj.Peek() > 0)
            {
                string Details = streamReaderObj.ReadLine();
                if (Details != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] NetworkDetails = Details.Split(':');
                        if (NetworkDetails.Length > 3)
                        {
                            string[] mydateTime = NetworkDetails[1].Split(' ');
                            Status[i] = mydateTime[0];
                            Status[i + 1] = mydateTime[1] + ":" + NetworkDetails[2] + ":" + NetworkDetails[3];
                            i++;

                        }
                        else
                        {
                            Status[i] = NetworkDetails[1];


                            if (NetworkDetails[1] == "Dialled")
                            {
                                Console.Write(Status[0] + "\t" + Status[1] + "\t" + Status[2] + "\t" + Status[3] + "\t" + Status[4] + "\t" + Status[5] + "\t");
                                Details = streamReaderObj.ReadLine();
                                string[] network = Details.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(Status, 0, Status.Length);
                                Console.WriteLine();
                            }

                        }
                        Details = streamReaderObj.ReadLine();

                    }
                }
                else
                {



                }

            }


        }
        public void Missed()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Sai Kumar\Desktop\C# Trining\FileHandling\NetworkDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            Console.WriteLine("Id\tSourse\t\tDestination\tDate\t\tTime\t\tStatus\tNetwork");
            string[] Status = new string[6];
            while (streamReaderObj.Peek() > 0)
            {
                string Details = streamReaderObj.ReadLine();
                if (Details != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] NetworkDetails = Details.Split(':');
                        if (NetworkDetails.Length > 3)
                        {
                            string[] mydateTime = NetworkDetails[1].Split(' ');
                            Status[i] = mydateTime[0];
                            Status[i + 1] = mydateTime[1] + ":" + NetworkDetails[2] + ":" + NetworkDetails[3];
                            i++;

                        }
                        else
                        {
                            Status[i] = NetworkDetails[1];


                            if (NetworkDetails[1] == "Missed")
                            {
                                Console.Write(Status[0] + "\t" + Status[1] + "\t" + Status[2] + "\t" + Status[3] + "\t" + Status[4] + "\t" + Status[5] + "\t");
                                Details = streamReaderObj.ReadLine();
                                string[] network = Details.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(Status, 0, Status.Length);
                                Console.WriteLine();
                            }

                        }
                        Details = streamReaderObj.ReadLine();

                    }
                }
                else
                {



                }

            }


        }

    }

    }

