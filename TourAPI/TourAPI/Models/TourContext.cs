using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourAPI.Models;

namespace TourAPI.Models
{
    public partial class TourContext : DbContext
    {
        public TourContext()
        { 
        }

        public TourContext(DbContextOptions<TourContext> options)
            : base(options)
        { 
        }

        public virtual DbSet<UserInfo> UserInfo { set; get; }

        public virtual DbSet<Customer> Customer { set; get; }

        public virtual DbSet<LineType> LineType { set; get; }

        public virtual DbSet<Line> Line { set; get; }

        public virtual DbSet<Orders> Orders { set; get; }

        public virtual DbSet<OrdersLineDetail> OrdersLineDetail { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TourDB;User ID=sa;Password=tw666");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserAccount)
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(e => e.UserGender)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

                entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(e => e.UserPosition)
                .IsRequired()
                .HasMaxLength(50);

            });
        }
    }
}