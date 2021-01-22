namespace WpfEFKutyak14d
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KutyaModel : DbContext
    {
        public KutyaModel()
            : base("name=KutyaModel")
        {
        }

        public virtual DbSet<kutya> kutya { get; set; }
        public virtual DbSet<kutyafajtak> kutyafajtak { get; set; }
        public virtual DbSet<kutyanevek> kutyanevek { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<kutyafajtak>()
                .HasMany(e => e.kutya)
                .WithRequired(e => e.kutyafajtak)
                .HasForeignKey(e => e.fajtaid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<kutyanevek>()
                .HasMany(e => e.kutya)
                .WithRequired(e => e.kutyanevek)
                .HasForeignKey(e => e.nevid)
                .WillCascadeOnDelete(false);
        }
    }
}
