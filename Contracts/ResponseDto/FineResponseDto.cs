using LMS_project.Entities;

namespace LMS_project.Contracts.ResponseDto;

public class FineResponseDto
{
    public int FineId { get; set; }
    
    public decimal Amount { get; set; }
    
    public bool IsPaid { get; set; }
    
    public int BookIssueId { get; set; }
    public BookIssue BookIssue { get; set; }
}