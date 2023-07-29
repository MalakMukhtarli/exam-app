namespace ExamApp.Models.Lessons;

public class LessonViewModel
{
    public int Code { get; set; }
    public string Name { get; set; }
    public List<byte> Grades { get; set; }
}