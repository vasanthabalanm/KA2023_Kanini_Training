//using SampleWebCoreApi.Models;

namespace WebApiSample.services.StudentService
{
    public interface IStudentService 
    {
        Task<List<Student>> GetAllStudentDetailes();
        Task<Student?> GetStudetailbyID(int id);
        Task<List<Student>> GetStudIDPost(Student student);
        Task<List<Student?>> UpdateStudIDPost(int id,Student student);
        Task<List<Student?>> DeleteStud(int id);


        /* Student GetStudIDPost();
         Student? UpdateStudIDPost(int id, Student su);*/


    }
}
