using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CINEMA.DB
{
    public partial class CinemaDatabase : DbContext
    {
        public CinemaDatabase()
        {
        }

        public CinemaDatabase(DbContextOptions<CinemaDatabase> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }
        public virtual DbSet<UserBookings> UserBookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\IRINA\\Documents\\GitHub\\Cinema\\CinemaDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserBookings>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
