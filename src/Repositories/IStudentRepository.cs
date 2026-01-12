using System.Collections.Generic;

namespace StudentManagement.Api.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void Add(Student student);
    }
}
