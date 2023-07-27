using System.ComponentModel.DataAnnotations;

namespace ExamApp.Entities.Models;

public class Lesson : CommonEntity
{
    public Lesson()
    {
        LessonGradeTeachers = new HashSet<LessonGradeTeacher>();
    }

    [Required] [StringLength(3)] public char Code { get; set; }
    [Required] [StringLength(30)] public string Name { get; set; }
    
    public virtual ICollection<LessonGradeTeacher> LessonGradeTeachers { get; set; }
}