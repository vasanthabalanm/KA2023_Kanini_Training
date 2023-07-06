using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;
using WebApiSample.services.StudentService;
using System;
using System.Net.NetworkInformation;

namespace WebApiSample.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;//sct as an encapsulate
        //if u select _studentserviceright clk to go to definition,it hide our code...
        public StudentController(IStudentService studentService) { 
            _studentService = studentService;
        
        }
        /*private static List<Student> students = new List<Student>
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

        

       
        [HttpGet]
        //select
        public async Task<ActionResult<List<Student>>> GetAllStudentDetailes()
        {
            /*List<Student> students = new List<Student>
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
                   },
            };*/

            //no print
            /*foreach (var stud in students) {
                Console.WriteLine(stud.StuID);
            }*/
            return await _studentService.GetAllStudentDetailes();
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List< Student>>> GetStudetailbyID(int id)
        {
            var stds = await _studentService.GetStudetailbyID(id);

            if (stds == null)
            {
                return null;
            }
            return Ok(stds);
            //return await _studentService.GetStudetailbyID(id);
        }

        [HttpPost]
        public async Task<ActionResult<List< Student>>> GetStudIDPost(Student stdts)
        {
            var stds = await _studentService.GetStudIDPost(stdts);
            return Ok(stds);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Student>>> UpdateStudIDPost(int id, Student su)
        {
            //var stud = students.Where(s => s.StuID == id).FirstOrDefault();
            var stud = await _studentService.UpdateStudIDPost(id,su);
            return Ok(stud);
        }
        

        //remove
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStud(int id)
        {
            return await _studentService.DeleteStud(id);

        }
        
       /* 
        //add/append/insert
        [HttpPost]
        public async Task<ActionResult<List<Student>>> GetStudIDPost()
        {
            //var stud = students.Where(s => s.StuID == id).FirstOrDefault();

            var stud = _studentService.GetStudIDPost();
            //stude.Add(stud);
            return Ok(stud);
        }
        
        //update
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Student>>> UpdateStudIDPost(int id, Student su)
        {
            //var stud = students.Where(s => s.StuID == id).FirstOrDefault();
            var stud = _studentService.UpdateStudIDPost(id,su);
            return Ok(stud);
        }
        /*
        //remove
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudIDPost(int id)
        {
            //var stud = students.Where(s => s.StuID == id).FirstOrDefault();
            var stud = students.Where(s => s.StuID == id).FirstOrDefault();

            if (stud == null)
            {
                return NotFound("id is not matching");
            }
            students.Remove(stud);
            return Ok(students);
        }
        */

    }
}
