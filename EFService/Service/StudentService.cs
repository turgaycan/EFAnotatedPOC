using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Domain;
using EFDAL.Repository;

namespace EFService.Service
{
    public class StudentService
    {
        private StudentRepository studentRepository;

        public StudentService()
        {
            studentRepository = new StudentRepository();
        }

        public void Save(Student student)
        {
            studentRepository.Add(student);
        }

        public List<Student> GetStudents()
        {
            return studentRepository.All.Include(c => c.Course).ToList();
        }

    }
}
