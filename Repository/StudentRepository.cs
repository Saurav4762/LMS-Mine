using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using System.Collections.Generic;
using LMS_project.Contracts.ResponseDto;
using LMS_project.Data;
using LMS_project.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LMS_project.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<StudentResponseDto>> GetAllStudentsAsync()
    {
        var students = await _context.Students
            .Select(a => new StudentResponseDto
            {
                Id = a.StudentId,
                Name = a.Name,
                Email = a.Email,
                Phone = a.Phone,
            })
            .ToListAsync();
        
        
        
        return students;
    }

    public async Task<StudentResponseDto> GetStudentsByIdAsync(int id)
    {
        var student = await _context.Students
            .Where((a) => a.StudentId == id)
            .Select(a => new StudentResponseDto
            {
                Id = a.StudentId,
                Name = a.Name,
                Email = a.Email,
                Phone = a.Phone,
            }).FirstOrDefaultAsync();
        
        return student;
    }
}