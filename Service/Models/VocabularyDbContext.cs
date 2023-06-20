using Microsoft.EntityFrameworkCore;
using Service.Models;

namespace VocabularyProject.Models
{
    public class VocabularyDbContext : DbContext
    {
        public VocabularyDbContext(DbContextOptions<VocabularyDbContext> context) : base(context)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Set>? Sets { get; set; }
        public DbSet<Word>? Words { get; set; }
        public DbSet<LearnedDates>? LearnedDates { get; set; }
        public DbSet<Folders> Folders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.ID);
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.HasOne(x => x.Users)
                      .WithMany(y => y.Sets)
                      .HasForeignKey(z => z.UserID)
                      .HasConstraintName("FK_Sets_Users");
            });

            modelBuilder.Entity<Folders>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.HasOne(x => x.Users)
                      .WithMany(y => y.Folders)
                      .HasForeignKey(z => z.UserID)
                      .HasConstraintName("FK_Folders_Users");
            });

            modelBuilder.Entity<LearnedDates>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.HasOne(x => x.Users)
                      .WithMany(y => y.LearnedDates)
                      .HasForeignKey(z => z.UserID)
                      .HasConstraintName("FK_LearnedDates_Users");
            });

            modelBuilder.Entity<Word>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.HasOne(x => x.Sets)
                      .WithMany(y => y.Words)
                      .HasForeignKey(z => z.SetID)
                      .HasConstraintName("FK_Words_Sets");
            });

            modelBuilder.Seed();

            //base.OnModelCreating(modelBuilder);
        }
    }
}