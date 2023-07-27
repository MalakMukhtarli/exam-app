namespace ExamApp.Entities.Models;

public class PupilGrade : CommonEntity
{
    public int PupilId { get; set; }
    public Pupil Pupil { get; set; }
    public int GradeId { get; set; }
    public Grade Grade { get; set; }
}