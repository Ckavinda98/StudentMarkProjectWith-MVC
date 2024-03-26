namespace StudentMarkProject.Web.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public List<School> Schools { get; } = new List<School>();
        public List<Grade> Grades { get; } = new List<Grade>();
    }
}
