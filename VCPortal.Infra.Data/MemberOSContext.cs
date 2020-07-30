using Microsoft.EntityFrameworkCore;
using VCPortal.Core.Domain;

namespace VCPortal.Infra.Data
{
    public sealed class MemberOSContext : DbContext
    {
        public MemberOSContext()
        {
        }

        public MemberOSContext(DbContextOptions<MemberOSContext> options)
            : base(options)
        {
        }

        public  DbSet<Contract> Contracts { get; set; }
        public  DbSet<Membership> Memberships { get; set; }
        public  DbSet<Scheme> Schemes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("VC_TemplatesByContract");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardType).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Network).HasMaxLength(100);

                entity.Property(e => e.PolicyNo).HasMaxLength(100);

                entity.Property(e => e.Scheme).HasMaxLength(100);
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.ToTable("VC_TemplatesByMembershipNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Scheme)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Scheme>(entity =>
            {
                entity.ToTable("VC_TemplatesByScheme");

                entity.Property(e => e.ContractNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SchemeName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
