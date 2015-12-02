using System.Linq;
using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Repository.Base;

namespace EFAnotatedPOC.Repository
{
    public class CourseRepository : AbstractBaseEntityRepository<Course, long>
    {
        public Course First()
        {
            return Context.TSet.First();
        }
    }
}
