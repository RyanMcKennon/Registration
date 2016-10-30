using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EfRegistration
{
    public class EfDelete
    {
        private RegistrationDBEntities db = new RegistrationDBEntities();

        public bool deleteStudent (int studentID)
        {

            var student = db.Students.Where(x => x.StudentID == studentID).FirstOrDefault();
            db.Students.Remove(student);
            return db.SaveChanges() > 0;
        }

        public bool deleteBuilding(int building)
        {
            var buildingToDrop = db.Buildings.Where(x => x.BuildingID == building).FirstOrDefault();
            db.Buildings.Remove(buildingToDrop);
            return db.SaveChanges() > 0;
        }

        public bool deleteClassRoom(int classRoom)
        {
            var classRoomToDrop = db.ClassRooms.Where(x => x.ClassRoomID == classRoom).FirstOrDefault();
            db.ClassRooms.Remove(classRoomToDrop);
            return db.SaveChanges() > 0;
        }

        public bool deleteCourse(int course)
        {
            var courseToDrop = db.Courses.Where(x => x.CourseID == course).FirstOrDefault();
            db.Courses.Remove(courseToDrop);
            return db.SaveChanges() > 0;
        }

        public bool deleteEnrollment(int enrollment)
        {
            var enrollmentToDrop = db.Enrollments.Where(x => x.EnrollmentID == enrollment).FirstOrDefault();
            db.Enrollments.Remove(enrollmentToDrop);
            return db.SaveChanges() > 0;
        }

        public bool deleteProfessor(int professor)
        {
            var professorToDrop = db.Professors.Where(x => x.ProfessorID == professor).FirstOrDefault();
            db.Professors.Remove(professorToDrop);
            return db.SaveChanges() > 0;
        }

        public bool deleteRoom(int room)
        {
            var roomToDrop = db.Rooms.Where(x => x.RoomID == room).FirstOrDefault();
            db.Rooms.Remove(roomToDrop);
            return db.SaveChanges() > 0;
        }
    }
}
