using ExamApp.Entities;
using ExamApp.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Exam> Exams { get; set; }
    public virtual DbSet<Grade> Grades { get; set; }
    public virtual DbSet<Lesson> Lessons { get; set; }
    public virtual DbSet<LessonGradeTeacher> LessonGradeTeachers { get; set; }
    public virtual DbSet<LessonGradeTeacher> LessonGrades { get; set; }
    public virtual DbSet<Pupil> Pupils { get; set; }
    public virtual DbSet<PupilExam> PupilExams { get; set; }
    public virtual DbSet<PupilGrade> PupilGrades { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    
    
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<CommonEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.UtcNow.AddHours(4);
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedDate = DateTime.UtcNow.AddHours(4);
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}