using System.ComponentModel.DataAnnotations;

namespace ExamApp.Entities.Models;

public class Grade : CommonEntity
{
    public Grade()
    {
        LessonGradeTeachers = new HashSet<LessonGradeTeacher>();
        PupilGrades = new HashSet<PupilGrade>();
    }

    [Required] public byte Value { get; set; }
    
    public virtual ICollection<LessonGradeTeacher> LessonGradeTeachers { get; set; }
    public virtual ICollection<PupilGrade> PupilGrades { get; set; }

}