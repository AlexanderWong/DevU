namespace Rocks
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MineralsEntities : DbContext
    {
        public MineralsEntities()
            : base("name=MineralsEntities")
        {
        }

        public virtual DbSet<Mineral> Minerals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mineral>()
                .Property(e => e.MineralName)
                .IsUnicode(false);

            modelBuilder.Entity<Mineral>()
                .Property(e => e.Formula)
                .IsUnicode(false);

            modelBuilder.Entity<Mineral>()
                .Property(e => e.CrystalClass)
                .IsUnicode(false);

            modelBuilder.Entity<Mineral>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Mineral>()
                .Property(e => e.Habit)
                .IsUnicode(false);
        }
    }
}
