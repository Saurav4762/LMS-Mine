using LMS_project.Entities;

namespace LMS_project.Contracts.ResponseDto;

public class BookResponseDto
{
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public string ISBN { get; set; }
    
    public int TotalCopies { get; set; }
    
    public int AvailableCopies { get; set; }
    
    // Foreign keys
    public int AuthorId { get; set; }
    
    public Author Author { get; set; }
    
    public int categoryId { get; set; }
    public Category Category { get; set; }
}