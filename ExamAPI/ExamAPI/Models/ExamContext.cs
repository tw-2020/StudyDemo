using System;
using ExamApi.Models;
using ExamUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExamAPI.Models
{
    public partial class ExamContext : DbContext
    {
        public ExamContext()
        {
        }

        public ExamContext(DbContextOptions<ExamContext> options)
            : base(options)
        {
        }

         public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<Paper> Paper { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ExamDB;User ID=sa;Password=tw666");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.AnswerID).HasColumnName("AnswerID");

                entity.Property(e => e.AnswerTime).HasColumnType("datetime");

                entity.Property(e => e.BatchTime).HasColumnType("datetime");

                entity.Property(e => e.PaperID).HasColumnName("PaperID");

                entity.Property(e => e.StuID).HasColumnName("StuID");

                entity.Property(e => e.SubmitTime).HasColumnType("datetime");

                entity.Property(e => e.TeacherID).HasColumnName("TeacherID");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.PaperID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__PaperID__1CF15040");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.StuID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__StuID__1DE57479");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.TeacherID)
                    .HasConstraintName("FK__Answer__TeacherI__1ED998B2");
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.Property(e => e.DetailID).HasColumnName("DetailID");

                entity.Property(e => e.AnswerID).HasColumnName("AnswerID");

                entity.Property(e => e.DetailAnswer).HasMaxLength(200);

                entity.Property(e => e.TopicID).HasColumnName("TopicID");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.Detail)
                    .HasForeignKey(d => d.AnswerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detail__AnswerID__21B6055D");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Detail)
                    .HasForeignKey(d => d.TopicID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detail__TopicID__22AA2996");
            });

            modelBuilder.Entity<Paper>(entity =>
            {
                entity.Property(e => e.PaperID).HasColumnName("PaperID");

                entity.Property(e => e.PaperExplain)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PaperName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StuID)
                    .HasName("PK__Student__6CDFAB75CEEA4650");

                entity.HasIndex(e => e.StuLoginName)
                    .HasName("UQ__Student__94E0857570B873AE")
                    .IsUnique();

                entity.Property(e => e.StuID).HasColumnName("StuID");

                entity.Property(e => e.StuEmail).HasMaxLength(50);

                entity.Property(e => e.StuGrade).HasMaxLength(50);

                entity.Property(e => e.StuLoginName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StuLoginPwd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('111')");

                entity.Property(e => e.StuName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StuPhone).HasMaxLength(20);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasIndex(e => e.TeacherLoginName)
                    .HasName("UQ__Teacher__5FCE442FC37BACCD")
                    .IsUnique();

                entity.Property(e => e.TeacherID).HasColumnName("TeacherID");

                entity.Property(e => e.TeacherEmail).HasMaxLength(50);

                entity.Property(e => e.TeacherLoginName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TeacherLoginPwd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('111')");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TeacherPhone).HasMaxLength(20);
            });



            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.PaperId).HasColumnName("PaperID");

                entity.Property(e => e.TopicA).HasMaxLength(100);

                entity.Property(e => e.TopicAnswer)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TopicB).HasMaxLength(100);

                entity.Property(e => e.TopicC).HasMaxLength(100);

                entity.Property(e => e.TopicD).HasMaxLength(100);

                entity.Property(e => e.TopicExplain)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.Topic)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Topic__PaperID__1A14E395");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
