

using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Repository;

namespace EFAnotatedPOC.Service
{
    public class CourseService
    {
        private CourseRepository courseRepository;

        public CourseService()
        {
            courseRepository = new CourseRepository();
        }

        public void Save(Course course)
        {
            courseRepository.Add(course);
        }

        public Course FindById(object courseId)
        {
            return courseRepository.FindById(courseId);
        }


    }
}
