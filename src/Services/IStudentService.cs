using System.Collections.Generic;
using StudentManagement.Api.DTOs;

namespace StudentManagement.Api.Services
{
    public interface IStudentService
    {
        IEnumerable<StudentDto> GetStudents();
    }
}
