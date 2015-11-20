using EFAnotatedPOC.Context;
using EFGeneric.Repository;

namespace EFAnotatedPOC.Repository.Base
{
    public abstract class AbstractBaseEntityRepository<T> : AbstractRepository<Context<T>, T> where T : class
    {

    }

}
