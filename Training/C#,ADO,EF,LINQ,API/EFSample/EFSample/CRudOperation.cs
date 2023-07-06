using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample
{
    internal class CRudOperation
    {
        public void InsertRecordsInCouseEntity()
        {
            using (var context = new CollegeContext())
            {
                var cour = new Course()
                {
                    CourseID = 1,
                    CourseName = "IT",
                };
                context.Courses.Add(cour);
                context.SaveChanges();
            }
        }
        public void InsertRecordsInStudentEntity()
        {
            using (var context = new CollegeContext())
            {
                var stud = new Student()
                {
                    Studid = 4,
                    Name = "raja",
                    Age = 24,
                };
                context.Students.Add(stud);
                context.SaveChanges();
            }
        }
        public void UpdateRecordsInStudentEntity()
        {
            /*using (var context = new CollegeContext())
            {
                context.Students.First<Student>().Age = 20;
                context.SaveChanges();
            }*/
            using (var context = new CollegeContext())
            {
                context.Students.First<Student>(s=>s.Age==20).Age = 20;
                context.SaveChanges();
            }
        }
        public void DeleteRecordsInStudentEntity()
        {
            using (var context = new CollegeContext())
            {
                context.Students.Remove(context.Students.First<Student>());
                context.SaveChanges();
            }
           

        }
        public void QueryMetd(string sname)
        {
            var contxt = new CollegeContext();
            var res = contxt.Students.Where(s => s.Name == sname).ToList();
            foreach(var s in res)
            {
                Console.WriteLine(s.Studid);
            }

        }
    }
}
