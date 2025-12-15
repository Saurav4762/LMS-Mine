using LMS_project.Entities;

namespace LMS_project.Contracts.RequestDto;

public class FineRequestDto
{
    public decimal Amount { get; set; }
    
    public bool Ispaid { get; set; }
    
    public int BookeIssueId { get; set; }
    
    public BookIssue BookIssue { get; set; }
}