﻿using System.Data.Entity;
using System.Diagnostics;
using EFGeneric.Base.Entity;
using EFGeneric.Context;

namespace EFAnotatedPOC.Context
{
    public class Context<T, PK> : EntityContext<PK> where T : BaseEntity<PK>
    {
        public Context()
            : base("name=YourDBContext")
        {
			//Logging for sql output..
            Database.Log = s => Debug.Write(s);
        }

        public DbSet<T> TSet { get; set; }
    }
}
