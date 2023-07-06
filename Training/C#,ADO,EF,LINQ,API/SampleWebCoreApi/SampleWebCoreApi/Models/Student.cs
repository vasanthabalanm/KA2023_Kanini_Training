namespace SampleWebCoreApi.Models
{
    public class Student
    {
        public int StuID { get; set; }
        public string StudName { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public int Pin { get; set; }
    }
}
