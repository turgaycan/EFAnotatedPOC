using EFDAL.Context;
using EFGeneric.Base.Entity;
using EFGeneric.Repository;

namespace EFDAL.Repository.Base
{
    public abstract class AbstractBaseEntityRepository<T, PK> : AbstractRepository<Context<T, PK>, T, PK> where T : BaseEntity<PK>
    {

    }

}
