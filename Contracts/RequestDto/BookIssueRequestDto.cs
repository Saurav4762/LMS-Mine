using LMS_project.Entities;

namespace LMS_project.Contracts.RequestDto;

public class BookIssueRequestDto
{
    public DateTime IssueDate { get; set; }
    
    public DateTime? ReturnDate { get; set; }
    
    public int BookId { get; set; }
    public Book Book { get; set; }
    
    public int studenId { get; set; }
    public Student  Student { get; set; }

    public bool IsRetuened { get; set; }

}