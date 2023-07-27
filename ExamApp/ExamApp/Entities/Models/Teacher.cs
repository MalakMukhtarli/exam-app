using System.ComponentModel.DataAnnotations;

namespace ExamApp.Entities.Models;

public class Teacher : CommonEntity
{
    public Teacher()
    {
        LessonGradeTeachers = new HashSet<LessonGradeTeacher>();
    }

    [Required] [StringLength(20)] public string Name { get; set; }
    [Required] [StringLength(20)] public string Surname { get; set; }
    public virtual ICollection<LessonGradeTeacher> LessonGradeTeachers { get; set; }
}