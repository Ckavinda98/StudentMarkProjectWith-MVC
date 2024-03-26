namespace StudentMarkProject.Web.Models
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public int SubjectId { get; set; }
        public List<School> Schools { get; set; } = new List<School>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
