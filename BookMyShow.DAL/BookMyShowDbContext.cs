using System;
using System.Collections.Generic;
using BookMyShow.Models.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookMyShow.DAL
{
    public partial class BookMyShowDbContext : DbContext
    {
        public BookMyShowDbContext()
        {
        }

        public BookMyShowDbContext(DbContextOptions<BookMyShowDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<CityTheatresMapping> CityTheatresMappings { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<Theatre> Theatres { get; set; } = null!;
        public virtual DbSet<TheatreScreenMapping> TheatreScreenMappings { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.MovieTheaterId)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SeatNo)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Location }, "Unique_Mapping_City_Location")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("City")
                    .IsFixedLength();

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CityTheatresMapping>(entity =>
            {
                entity.ToTable("CityTheatresMapping");

                entity.HasIndex(e => new { e.CityId, e.TheatreId }, "Unique_Mapping_City_Theatre")
                    .IsUnique();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CityTheatresMappings)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CityTheatresMapping_CityId");

                entity.HasOne(d => d.Theatre)
                    .WithMany(p => p.CityTheatresMappings)
                    .HasForeignKey(d => d.TheatreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CityTheatresMapping_TheatreId");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Cast)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Theatre>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TheatreScreenMapping>(entity =>
            {
                entity.ToTable("TheatreScreenMapping");

                entity.HasIndex(e => new { e.TheatreId, e.MovieId, e.MovieDateTime }, "Unique_Mapping_Theatre_Screens")
                    .IsUnique();

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.TheatreScreenMappings)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TheatreScreenMapping_Movies");

                entity.HasOne(d => d.Theatre)
                    .WithMany(p => p.TheatreScreenMappings)
                    .HasForeignKey(d => d.TheatreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TheatreScreenMapping_Theatres");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
