namespace StudentMarkProject.Web.Models
{
    public class TeacherEnrollment
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SchoolId { get; set; }
        public int SubjectId { get; set; }
    }
}
