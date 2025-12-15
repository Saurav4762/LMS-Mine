using LMS_project.Data;
using LMS_project.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.TestUtilities;

namespace LMS_project.Controllers;

[Route("api/[controller]")]
[ApiController]

public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;
    private readonly ApplicationDbContext _context;

    public StudentController(ApplicationDbContext context, IStudentRepository studentRepository)
    {
        _context = context;
        _studentRepository = studentRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        try
        {
            var student = await _studentRepository.GetAllStudentsAsync();

            return Ok(new { message = "Student retrived sucessfully", data = student });

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);

        }

    }

}