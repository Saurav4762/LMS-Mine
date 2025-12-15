namespace LMS_project.Entities;

public class Book
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