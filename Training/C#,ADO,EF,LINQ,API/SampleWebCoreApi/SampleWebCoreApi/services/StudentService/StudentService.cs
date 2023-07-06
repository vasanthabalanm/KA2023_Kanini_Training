using Microsoft.AspNetCore.Mvc;
using SampleWebCoreApi.Models;

namespace SampleWebCoreApi.services.StudentService
{
    public class StudentService : IStudentService
    {
        private static List<Student> studentsLst = new List<Student>
            {
                new Student {
                            StuID = 1 ,
                            StudName = "ram" ,
                            City ="chennai",
                            Pin =376236
                },
                 new Student {
                            StuID = 2 ,
                            StudName = "Bala" ,
                            City ="chennai",
                            Pin =86434
                 },
                  new Student {
                            StuID = 3 ,
                            StudName = "nandha" ,
                            City ="coimbatore",
                            Pin =4787384
                  },
                   new Student {
                            StuID = 4 ,
                            StudName = "senthil" ,
                            City ="sivaganga",
                            Pin =89834
                   }
            };
        public List<Student> GetAllStudentDetailes()
        {
            return studentsLst;
        }
        public  Student? GetStudetailbyID(int id)
        {
            var stud = studentsLst.Where(s => s.StuID == id).FirstOrDefault();

            if (stud == null)
            {
                return null ;
            }
            return stud;
        }
        public Student GetStudIDPost()
        {
            //var stud = students.Where(s => s.StuID == id).FirstOrDefault();

            var stud = new Student
            {
                StuID = 8,
                City = "uchiha",
                Pin = 65878,
                StudName = "Madara"

            };
            studentsLst.Add(stud);
            return stud;
        }
        public Student UpdateStudIDPost(int id, Student su)
        {
            //var stud = students.Where(s => s.StuID == id).FirstOrDefault();
            var stud = studentsLst.Where(s => s.StuID == id).FirstOrDefault();

            if (stud == null)
            {
                return null;
            }
            stud.StudName = su.StudName;
            stud.City = su.City;
            stud.Pin = su.Pin;
            return stud;
        }
    }
}
