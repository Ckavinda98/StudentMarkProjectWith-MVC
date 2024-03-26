namespace StudentMarkProject.Web.Models
{
    public class StudentMarkViewModel
    {
        public int Id { get; set; }

        public int Marks { get; set; }

        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
