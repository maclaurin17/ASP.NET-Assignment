using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models.DB_Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);
        }
    }
}
