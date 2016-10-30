using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRegistration
{
    public partial class EfInserts
    {
        private RegistrationDBEntities db = new RegistrationDBEntities();

        public bool InsertStudent(Student student)
        {
            db.Students.Add(student);
            return db.SaveChanges() > 0;
        }

        public bool InsertProfessor(Professor prof)
        {
            db.Professors.Add(prof);
            return db.SaveChanges() > 0;
        }

        public bool InsertBuilding(Building building)
        {
            db.Buildings.Add(building);
            return db.SaveChanges() > 0;
        }

        public bool InsertRoom(Room room)
        {
            db.Rooms.Add(room);
            return db.SaveChanges() > 0;
        }

        public bool InsertClassRoom(ClassRoom classroom)
        {
            db.ClassRooms.Add(classroom);
            return db.SaveChanges() > 0;
        }

        public bool InsertCourse(Course course)
        {
            db.Courses.Add(course);
            return db.SaveChanges() > 0;
        }

        public bool insertEnrollment(Enrollment enrollment)
        {
            db.sp_InsertEnrollment(enrollment.StudentID,enrollment.CourseID,enrollment.CourseName,enrollment.CourseNumber,enrollment.ClassStartTime);
            return db.SaveChanges() > 0;
        }
    }
}
