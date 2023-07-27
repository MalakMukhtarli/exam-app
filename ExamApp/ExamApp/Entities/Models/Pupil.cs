using System.ComponentModel.DataAnnotations;

namespace ExamApp.Entities.Models;

public class Pupil : CommonEntity
{
    public Pupil()
    {
        PupilGrades = new HashSet<PupilGrade>();
        PupilExams = new HashSet<PupilExam>();
    }
    
    [Required] public int Number { get; set; }
    [Required] [StringLength(30)] public string Name { get; set; }
    [Required] [StringLength(30)] public string Surname { get; set; }

    public virtual ICollection<PupilGrade> PupilGrades { get; set; }
    public virtual ICollection<PupilExam> PupilExams { get; set; }
}