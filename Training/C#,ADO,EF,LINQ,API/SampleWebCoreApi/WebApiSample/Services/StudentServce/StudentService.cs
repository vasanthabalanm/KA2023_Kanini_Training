using WebApiSample.Models;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApiSample.services.StudentService
{
    public class StudentService : IStudentService
    {
        public StudentDataContxt _studentcntxt;
        public StudentService( StudentDataContxt studentDataContxt)
        {
            _studentcntxt = studentDataContxt;
        }
        /*private static List<Student> studentsLst = new List<Student>
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
            };*/
        public async Task< List<Student>> GetAllStudentDetailes()
        {
            var stds =await _studentcntxt.Students.ToListAsync();
            return stds;
        }
        public  async Task< Student?> GetStudetailbyID(int id)
        {
            var stds = await _studentcntxt.Students.FindAsync(id);

            if (stds == null)
            {
                return null ;
            }
            return (stds);
        }
        public async Task<List< Student>> GetStudIDPost(Student studs)
        {
            _studentcntxt.Students.Add(studs);
            await _studentcntxt.SaveChangesAsync();
            return await _studentcntxt.Students.ToListAsync();

        }
        public async Task<List<Student>> UpdateStudIDPost(int id, Student std)
        {
            //var stud = students.Where(s => s.StuID == id).FirstOrDefault();
            var stud = await _studentcntxt.Students.FindAsync(id);

            if (stud == null)
            {
                return null;
            }
            stud.StudName = std.StudName;
            stud.City = std.City;
            stud.Pin = std.Pin;
            await _studentcntxt.SaveChangesAsync();
            return await _studentcntxt.Students.ToListAsync();
            //return stud;
        }
        public async Task<List<Student>> DeleteStud(int id)
        {
            var del = await _studentcntxt.Students.FirstOrDefaultAsync(ids => ids.StuID == id);
            _studentcntxt.Remove(del);
            _studentcntxt.SaveChanges();
            return await _studentcntxt.Students.ToListAsync();
        }
    /*
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
    }*/
}
}
