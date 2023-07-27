namespace ExamApp.Entities;

public interface ISoftDeletedEntity
{
    bool Deleted { get; set; }
}