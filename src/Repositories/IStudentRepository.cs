using System.Collections.Generic;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void Add(Student student);
    }
}
