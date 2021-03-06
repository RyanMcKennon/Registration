﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfRegistration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RegistrationDBEntities : DbContext
    {
        public RegistrationDBEntities()
            : base("name=RegistrationDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<ClassRoom> ClassRooms { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    
        public virtual int sp_InsertEnrollment(Nullable<int> studentID, Nullable<int> courseID, string courseName, Nullable<int> courseNumber, Nullable<System.TimeSpan> classStartTime)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            var courseIDParameter = courseID.HasValue ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(int));
    
            var courseNameParameter = courseName != null ?
                new ObjectParameter("CourseName", courseName) :
                new ObjectParameter("CourseName", typeof(string));
    
            var courseNumberParameter = courseNumber.HasValue ?
                new ObjectParameter("CourseNumber", courseNumber) :
                new ObjectParameter("CourseNumber", typeof(int));
    
            var classStartTimeParameter = classStartTime.HasValue ?
                new ObjectParameter("ClassStartTime", classStartTime) :
                new ObjectParameter("ClassStartTime", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertEnrollment", studentIDParameter, courseIDParameter, courseNameParameter, courseNumberParameter, classStartTimeParameter);
        }
    }
}
