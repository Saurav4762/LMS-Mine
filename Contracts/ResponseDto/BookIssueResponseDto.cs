using LMS_project.Entities;

namespace LMS_project.Contracts.ResponseDto;

public class BookIssueResponseDto
{
    public int BookIssueId { get; set; }
    
    public DateTime IssueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    
    // Foreign keys
    public int BookId { get; set; }
    public Book Book { get; set; }
    
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public bool IsReturned()
    {
        return ReturnDate != null;
    }
}