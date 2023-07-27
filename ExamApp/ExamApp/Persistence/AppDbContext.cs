using Microsoft.EntityFrameworkCore;

namespace ExamApp.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    
}