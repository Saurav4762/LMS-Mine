using LMS_project.Entities;

namespace LMS_project.Contracts.RequestDto;

public class BookRequestDto
{
    public string Title { get; set; }
    
    public string ISBN {get; set;}
    
    public int TotalCopies {get; set;}
    
    public int AvailableCopies {get; set;}
    
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
}