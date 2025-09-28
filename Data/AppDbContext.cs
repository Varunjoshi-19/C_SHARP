using Microsoft.EntityFrameworkCore;
using testingApplication.Models;

namespace testingApplication.Data
{

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<BlogModel> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.HasIndex(u => u.Email).IsUnique();
                entity.Property(u => u.Username).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Password).IsRequired();
                entity.Property(u => u.CreatedAt).IsRequired();
                entity.Property(u => u.UpdatedAt).IsRequired();


            });

            modelBuilder.Entity<BlogModel>(entity =>
            {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Category).IsRequired().HasMaxLength(200);
                entity.Property(b => b.Title).IsRequired().HasMaxLength(200);
                entity.Property(b => b.BlogContent).IsRequired();
                entity.Property(b => b.CreatedAt).IsRequired();
                entity.Property(b => b.UpdatedAt).IsRequired();

                entity.HasOne(b => b.Author)
                    .WithMany(u => u.Blogs)
                    .HasForeignKey(b => b.AuthorId)
                    .OnDelete(DeleteBehavior.Cascade);


            });



        }


    }

}