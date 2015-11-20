using System.Data.Entity;
using System.Diagnostics;
using EFGeneric.Context;

namespace EFAnotatedPOC.Context
{
    public class Context<T> : EntityContext where T : class
    {

        public Context()
            : base("name=YourContext")
        {
			//Log your linq sql queries to console..
            Database.Log = s => Debug.Write(s);
        }

        public DbSet<T> TSet { get; set; }
    }
}
