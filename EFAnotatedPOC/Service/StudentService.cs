using System.Collections.Generic;
using System.Linq;
using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Repository;

namespace EFAnotatedPOC.Service
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
            return studentRepository.All.ToList();
        }

    }
}
