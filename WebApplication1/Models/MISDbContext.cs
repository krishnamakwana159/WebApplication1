namespace RxMis.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class MISDbContext : DbContext
    {
        public MISDbContext()
            : base("name=RxMISStagingConnectionString")
        {
            this.Database.CommandTimeout = 60;
        }

        //public MISDbContext() : base("Default")
        //{
        //    this.Database.CommandTimeout = 60;
        //}

        //public virtual DbSet<Employees> Employees { get; set; }

    }
}
