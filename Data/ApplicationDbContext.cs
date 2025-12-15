using LMS_project.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS_project.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Student> Students { get; set; }
    
    public DbSet<Author> Authors { get; set; }
    
    public DbSet<Book> Books { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<BookIssue> BookIssues { get; set; }
    
    public DbSet<Fine>  Fines { get; set; } 

}