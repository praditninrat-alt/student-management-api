using System.Collections.Generic;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetAll()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Student A", IsActive = true }
            };
        }

        public Student GetById(int id)
        {
            return new Student { Id = id, Name = "Student A", IsActive = true };
        }

        public void Add(Student student)
        {
            // Sample implementation
        }
    }
}
