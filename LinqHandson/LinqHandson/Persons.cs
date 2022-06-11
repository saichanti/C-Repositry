using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string name, string lastname, int age)
        {
            FirstName = name;
            LastName = lastname;
            Age = age;

        }
        public void startsletterD(string latter)
        {
            List<Person> people = new List<Person>()
             {
                 new Person("Bill", "Smith", 41),
                 new Person("Sarah", "Jones", 22),
                 new Person("Stacy","Baker", 21),
                 new Person("Vivianne","Dexter", 19 ),
                 new Person("Bob","Smith", 49 ),
                 new Person("Brett","Baker", 51 ),
                 new Person("Mark","Parker", 19),
                 new Person("Alice","Thompson", 18),
                 new Person("Evelyn","Thompson", 58 ),
                 new Person("Mort","Martin", 58),
                 new Person("Eugene","DeLauter", 84 ),
                 new Person("Gail","Dawson", 19 ),

             };
            var peopleWithlastname = from per in people where per.LastName.StartsWith(latter) select per.LastName;
            foreach (var person in peopleWithlastname)
            {

                Console.WriteLine(person);
            }
            int num = (from per in people where per.LastName.StartsWith(latter) select per.LastName).Count();


            Console.WriteLine("number of people whose lastname start with D  :" + num);

            Console.WriteLine(" first Person Older Than 40 In Descending Alphabetical Order By First Name");
            var names = from per in people orderby per.FirstName ascending where per.Age > 40 select per.FirstName;
            foreach (var person in names)
            {
                Console.Write(person + " ");
            }
        }
    }
}
