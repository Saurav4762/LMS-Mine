namespace LMS_project.Entities;

public class BookIssue
{
    public int BookIssueId { get; set; }
    
    public DateTime issueDate { get; set; }
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