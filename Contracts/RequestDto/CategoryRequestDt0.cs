using LMS_project.Entities;

namespace LMS_project.Contracts.RequestDto;

public class CategoryRequestDt0
{
    public string CategoryName { get; set; }
    
    public List<Book> Books { get; set; }
}