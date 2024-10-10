namespace StudentPortal.Models
{
    public class Student
    {
        public int studentId {  get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
