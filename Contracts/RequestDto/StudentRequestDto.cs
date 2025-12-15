using LMS_project.Entities;

namespace LMS_project.Contracts.RequestDto;

public class StudentRequestDto
{
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public bool IsActive { get; set; }
    
    public List<BookIssue> BookIssues { get; set; }
    
}