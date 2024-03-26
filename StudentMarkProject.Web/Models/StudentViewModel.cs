namespace StudentMarkProject.Web.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int StudentId { get; set; }
        public int SchoolId { get; set; }
        public int GradeId { get; set; }
        public List<School> Schools { get; set; } = new List<School>();
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
