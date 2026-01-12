using System.Collections.Generic;
using System.Linq;
using StudentManagement.Api.DTOs;
using StudentManagement.Api.Repositories;

namespace StudentManagement.Api.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<StudentDto> GetStudents()
        {
            return _repository.GetAll()
                .Select(s => new StudentDto
                {
                    Id = s.Id,
                    Name = s.Name
                });
        }
    }
}
