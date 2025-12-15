namespace LMS_project.Entities;

public class Fine
{
    public int FineId { get; set; }
    
    public decimal Amount { get; set; }
    
    public bool IsPaid { get; set; }
    
    public int BookIssueId { get; set; }
    public BookIssue BookIssue { get; set; }
    
}