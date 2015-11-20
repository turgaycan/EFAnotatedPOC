using System.Linq;
using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Repository.Base;

namespace EFAnotatedPOC.Repository
{
    public class CourseRepository : AbstractBaseEntityRepository<Course>
    {
        public override Course FindById(object id)
        {
            return Context.TSet.First();
        }
    }
}
