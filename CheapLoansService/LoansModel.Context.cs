﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheapLoansService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LoansDatabaseEntities : DbContext
    {
        public LoansDatabaseEntities()
            : base("name=LoansDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Loan> Loans { get; set; }
    
        public virtual ObjectResult<SelectAllProcedure_Result> SelectAllProcedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllProcedure_Result>("SelectAllProcedure");
        }
    }
}
