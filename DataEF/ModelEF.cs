using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataBaseTest.DataEF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Avtomobils> Avtomobils { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avtomobils>()
                .Property(e => e.Vladelec)
                .IsFixedLength();

            modelBuilder.Entity<Avtomobils>()
                .Property(e => e.Marka)
                .IsFixedLength();
        }
    }
}
