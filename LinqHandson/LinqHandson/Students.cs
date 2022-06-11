using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson
{
    internal class Students
    {
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public int StuId { get; set; }
        public void NthMaximumGradePoint()
        {
            List<Students> studentlist = new List<Students>();
            studentlist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            studentlist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            studentlist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            studentlist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            studentlist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            studentlist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            studentlist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            studentlist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            studentlist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            studentlist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            Console.WriteLine("Students list are : ");

            foreach (var stud in studentlist)
            {
                Console.WriteLine(" Id : {0},  Name : {1},Grade Point : {2}", stud.StuId, stud.StuName, stud.GrPoint);
            }
            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
            int gradePts = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            var students = (from stuMast in studentlist
                            group stuMast by stuMast.GrPoint into g
                            orderby g.Key descending
                            select new
                            {
                                StuRecord = g.ToList()
                            }).ToList();

            students[gradePts - 1].StuRecord
                .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1}," +
                "  achieved Grade Point : {2}", i.StuId, i.StuName, i.GrPoint));
            Console.ReadLine();
        }
    }
}
