using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        public DbSet<StudentTable> Students { get; set; }
        public DbSet<TeacherDetails> Teachers { get; set; }
        public DbSet<ResultTable> Result { get; set; }
        public DbSet<SubjectTable> Subject { get; set; }
        public DbSet<AuthorizationDetails> AuthorizationDetails { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StudentDetails>()
        //        .HasOne(e => e.Marks)
        //        .WithOne(e => e.Student)
        //        .HasForeignKey<MarksTable>();
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //studentsubject
            modelBuilder.Entity<StudentSubject>()
                .HasKey(bc => new { bc.StudentRollNumber, bc.SubjectCode });
            modelBuilder.Entity<StudentSubject>()
                .HasOne(bc => bc.Student)
                .WithMany(b => b.StudentSubjects)
                .HasForeignKey(bc => bc.StudentRollNumber);
            modelBuilder.Entity<StudentSubject>()
                .HasOne(bc => bc.Subject)
                .WithMany(c => c.StudentSubjects)
                .HasForeignKey(bc => bc.SubjectCode);

            //resultTable
            modelBuilder.Entity<StudentTable>()
                .HasOne(bc => bc.ResultTable)
                .WithOne(b => b.Student)
                .HasForeignKey<ResultTable>(bc => bc.studentId);
            modelBuilder.Entity<ResultTable>()
                .HasOne(bc => bc.Teacher)
                .WithMany(c => c.ResultTables)
                .HasForeignKey(bc => bc.teacherId);
        }
    }
}
