using System.Linq;
using Domain.Domain;
using EFDAL.Repository.Base;

namespace EFDAL.Repository
{
    public class CourseRepository : AbstractBaseEntityRepository<Course, long>
    {
        public Course First()
        {
            Course firstCourse = Context.TSet.Include("Students").FirstOrDefault(each => each.Id == 3);
            Course lastCourse = Context.TSet.Include("Students").FirstOrDefault(each => each.Id == 5);
            return Queryable.First(Context.TSet);
        }
    }
}
