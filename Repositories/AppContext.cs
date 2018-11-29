using Microsoft.EntityFrameworkCore;
using RepositoryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base()
        {
            //Database.EnsureCreated();// SetInitializer(new CreateDatabaseIfNotExists<AppContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local); Initial Catalog=Tweater; Integrated Security=SSPI;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var student = modelBuilder.Entity<User>();
            student.HasKey(s => s.Id);
            student.Property(s => s.Login).IsRequired().IsUnicode();
            student.Property(s => s.Password).IsRequired().IsUnicode();
            student.Property(s => s.Email).IsRequired();
            student.Property(s => s.Name).IsUnicode();

            var post = modelBuilder.Entity<Post>();
            post.Property(p => p.Content).IsRequired().IsUnicode();
            post.Property(p => p.CreatedDate).IsRequired();
            post.HasOne(p => p.Author).WithMany(s => s.Posts)
                .HasForeignKey(k => k.UserId);

            var comment = modelBuilder.Entity<Comment>();
            comment.Property(c => c.CreatedDate).IsRequired();
            comment.Property(c => c.Content).IsRequired().IsUnicode();
            comment.HasOne(c => c.Author).WithMany(s => s.Comments)
                .HasForeignKey(k => k.UserId).OnDelete(DeleteBehavior.Restrict);
            comment.HasOne(c => c.Post).WithMany(p => p.Comments)
                .HasForeignKey(k => k.PostId);

            /*var tag = modelBuilder.Entity<Tag>();
            tag.Property(t => t.Name).IsRequired();
            tag.HasMany(t => t.Posts).WithMany(p => p.Tags).Map(tp =>
            {
                tp.ToTable("PostTag");
                tp.MapLeftKey("TagId");
                tp.MapRightKey("PostId");
            });*/

            base.OnModelCreating(modelBuilder);
        }
    }
}
