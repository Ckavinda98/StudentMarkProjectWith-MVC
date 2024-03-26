namespace StudentMarkProject.Web.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<School> Schools { get; } = new List<School>();
        public List<Subject> Subjects { get; } = new List<Subject>();

    }
}
