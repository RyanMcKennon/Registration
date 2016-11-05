using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRegistration
{
    public class EfGetMethods
    {
        private RegistrationDBEntities db = new RegistrationDBEntities();

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }


        public List<Enrollment> GetEnrollments()
        {
            return db.Enrollments.ToList();
        }


        public List<Course> GetCourses()
        {
            return db.Courses.ToList();
        }


        public List<Professor> GetProfessors()
        {
            return db.Professors.ToList();
        }


        public List<Building> GetBuildings()
        {
            return db.Buildings.ToList();
        }


        public List<Room> GetRooms()
        {
            return db.Rooms.ToList();
        }


        public List<ClassRoom> GetClassRooms()
        {
            return db.ClassRooms.ToList();
        }





    }
}
