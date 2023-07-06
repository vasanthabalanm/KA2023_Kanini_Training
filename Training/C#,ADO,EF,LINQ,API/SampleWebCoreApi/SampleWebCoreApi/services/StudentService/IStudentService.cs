//using SampleWebCoreApi.Models;

namespace SampleWebCoreApi.services.StudentService
{
    public interface IStudentService 
    {
        List<Student> GetAllStudentDetailes();
        Student? GetStudetailbyID(int id);
        Student GetStudIDPost();
        Student? UpdateStudIDPost(int id, Student su);


    }
}
