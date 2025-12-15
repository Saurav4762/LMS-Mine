namespace LMS_project.Entities;

public class Student
{
    public int StudentId { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }

    public bool IsActive { get; set; } 
    
    public ICollection<BookIssue> BookIssues { get; set; }
    
}