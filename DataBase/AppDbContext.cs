using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<MetaTag> MetaTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Category Entity
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired();

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Questions)
                .WithOne(q => q.Category)
                .HasForeignKey(q => q.CategoryId);


            //Question Entity
            modelBuilder.Entity<Question>()
                .HasKey(q => q.CategoryId);

            modelBuilder.Entity<Question>()
                .Property(q => q.CategoryName)
                .IsRequired();

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(a => a.Questions)
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.MetaTags)
                .WithOne(m => m.Question)
                .HasForeignKey(m => m.CategoryId);

            //Answer Entity

            modelBuilder.Entity<Answer>()
                .HasKey(a => a.AnswerId);

            modelBuilder.Entity<Answer>()
           .Property(a => a.AnswerText)
           .IsRequired()
           .HasMaxLength(255);

            modelBuilder.Entity<Answer>()
                .Property(a => a.IsCorrect)
                .IsRequired();

            // Configure MetaTag entity
            modelBuilder.Entity<MetaTag>()
                .HasKey(m => m.MetaID);

            modelBuilder.Entity<MetaTag>()
                .Property(m => m.MetaName)
                .IsRequired()
                .HasMaxLength(100);




        }
    }
}
