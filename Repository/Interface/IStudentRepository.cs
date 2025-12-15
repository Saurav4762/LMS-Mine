using LMS_project.Contracts.ResponseDto;
using LMS_project.Entities;

namespace LMS_project.Repository.Interface;

public interface IStudentRepository 
{
    Task<List<StudentResponseDto>> GetAllStudentsAsync() ;
    
    Task<StudentResponseDto> GetStudentsByIdAsync(int id);
    
}