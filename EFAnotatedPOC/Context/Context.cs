using System.Data.Entity;
using EFGeneric.Base.Entity;
using EFGeneric.Context;

namespace EFAnotatedPOC.Context
{
    public class Context<T> : EntityContext where T : BaseEntity
    {
        public Context()
            : base("name=YourDomainContext")
        {

        }

        public DbSet<T> TSet { get; set; }
    }
}
