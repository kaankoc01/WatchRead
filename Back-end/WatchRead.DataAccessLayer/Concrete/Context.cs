using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =.\\SQLEXPRESS; initial catalog=WatchReadDb;integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentGenre> ContentGenres { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User ile Comment arasındaki 1'e çok ilişki
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);

            // User ile Favorite arasındaki 1'e çok ilişki
            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId);

            // User ile Rating arasındaki 1'e çok ilişki
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId);

            // Content ile Comment arasındaki 1'e çok ilişki
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Content)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.ContentId);

            // Content ile Favorite arasındaki 1'e çok ilişki
            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Content)
                .WithMany(c => c.Favorites)
                .HasForeignKey(f => f.ContentId);

            // Content ile Rating arasındaki 1'e çok ilişki
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Content)
                .WithMany(c => c.Ratings)
                .HasForeignKey(r => r.ContentId);

            // Content ve Category arasındaki 1'e çok ilişki
            modelBuilder.Entity<Content>()
                .HasOne(c => c.Category)
                .WithMany(cat => cat.Contents)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Content>()
                .Property(c => c.Rating)
                .HasColumnType("decimal(18,2)"); // 18 toplam basamak, 2 ondalık basamak

            modelBuilder.Entity<Rating>()
                .Property(r => r.Score)
                .HasColumnType("decimal(18,2)"); // 18 toplam basamak, 2 ondalık basamak

            // Content ve Genre arasında ContentGenre üzerinden çoktan çoğa ilişki
            modelBuilder.Entity<ContentGenre>()
                .HasKey(cg => new { cg.ContentId, cg.GenreId });

            modelBuilder.Entity<ContentGenre>()
                .HasOne(cg => cg.Content)
                .WithMany(c => c.ContentGenres)
                .HasForeignKey(cg => cg.ContentId);

            modelBuilder.Entity<ContentGenre>()
                .HasOne(cg => cg.Genre)
                .WithMany(g => g.ContentGenres)
                .HasForeignKey(cg => cg.GenreId);

            // User ile Role arasındaki çoktan çoğa ilişki
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);
        }

    }
}
