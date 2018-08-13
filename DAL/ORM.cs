namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DTO;
    using System.Collections.Generic;

    public partial class ORM : DbContext
    {
        public ORM()
            : base("name=ORM")
        {
        }

        public virtual DbSet<informatique> informatique { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<informatique>()
                .Property(e => e.id_mot_cle)
                .IsUnicode(false);

            modelBuilder.Entity<informatique>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
