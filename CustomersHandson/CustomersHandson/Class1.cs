using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customers
{
    
    
        public class CustomerData
        {
            int customerId { get; set; }
            string customerName { get; set; }
            string city { get; set; }
            long mobileNo { get; set; }
            int age { get; set; }
            int units { get; set; }
           
            int totalCost { get; set; }
            string paidOrNot { get; set; }

            List<CustomerData> myList = new List<CustomerData>();
        public void DataList()
        {
            myList.Add(new CustomerData
            {
                customerId = 1,
                customerName = "Saikumar",
                city = "Hyderabad",
                mobileNo = 9867865476,
                age = 23,
                units = 1000,

                paidOrNot = "not Paid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 2,
                customerName = "kavya",
                city = "hyderabad",
                mobileNo = 7987675642456,
                age = 24,
                units = 10,

                paidOrNot = "Paid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 3,
                customerName = "vamsy",
                city = "hgchsdbsa",
                mobileNo = 76576456789,
                age = 21,
                units = 7654,

                paidOrNot = "notPaid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 4,
                customerName = "kjhgfchjnb",
                city = "kjhgfdgh",
                mobileNo = 98765463,
                age = 22,
                units = 876,

                paidOrNot = "Not Paid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 5,
                customerName = "Saikumar",
                city = "Hyderabad",
                mobileNo = 9867865476,
                age = 23,
                units = 1000,

                paidOrNot = "not Paid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 6,
                customerName = "kavya",
                city = "hyderabad",
                mobileNo = 7987675642456,
                age = 24,
                units = 10,

                paidOrNot = "Paid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 7,
                customerName = "vamsy",
                city = "hgchsdbsa",
                mobileNo = 76576456789,
                age = 21,
                units = 7654,

                paidOrNot = "notPaid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 8,
                customerName = "kjhgfchjnb",
                city = "kjhgfdgh",
                mobileNo = 98765463,
                age = 22,
                units = 876,

                paidOrNot = "Not Paid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 9,
                customerName = "vamsy",
                city = "hgchsdbsa",
                mobileNo = 76576456789,
                age = 21,
                units = 7654,

                paidOrNot = "notPaid"
            }
            );
            myList.Add(new CustomerData
            {
                customerId = 10,
                customerName = "kjhgfchjnb",
                city = "kjhgfdgh",
                mobileNo = 98765463,
                age = 22,
                units = 876,

                paidOrNot = "Not Paid"
            }
            );
        }
            public void CustomerDetails(int iD)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (iD == myList[i].customerId)
                    {
                        Console.WriteLine(myList[i].customerId + " " + myList[i].customerName + " " + myList[i].city + " " + myList[i].mobileNo + " "
                            + myList[i].age);
                        break;
                    }
                }
                return;
            }
            public void EBill(int iD)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    if (iD == myList[i].customerId)
                    {
                        Console.WriteLine(myList[i].units + " " + myList[i].totalCost);
                        break;
                    }
                }
                return;
            }
            public void AllCustomers()
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine(myList[i].customerId + " " + myList[i].customerName + " " + myList[i].city + " " + myList[i].mobileNo + " "
                            + myList[i].age + myList[i].units + " " + myList[i].totalCost + " " + myList[i].paidOrNot);
                }
                return;
            }
        }
    }

