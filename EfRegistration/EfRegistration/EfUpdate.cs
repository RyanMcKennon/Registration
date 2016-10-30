using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRegistration
{
    public class EfUpdate
    {
        private RegistrationDBEntities db = new RegistrationDBEntities();

        public bool updateStudent(Student student)
        {
            int test = 0;
            var result = db.Students.SingleOrDefault(b => b.StudentID == student.StudentID);
            if (result != null)
            {
                if(student.StudentFirstName != null)
                    result.StudentFirstName = student.StudentFirstName;
                if (student.StudentLastName != null)
                    result.StudentLastName = student.StudentLastName;
                if (student.Major != null)
                    result.Major = student.Major;
                if (student.Active != null)
                    result.Active = student.Active;

                test = db.SaveChanges();
            }
            return test > 0;
        }

        public bool updateBuilding(Building building)
        {
            int test = 0;
            var result = db.Buildings.SingleOrDefault(b => b.BuildingID == building.BuildingID);
            if (result != null)
            {
                if (building.BuildingName != null)
                    result.BuildingName = building.BuildingName;
                test = db.SaveChanges();
            }
            return test > 0;
        }

        public bool updateClassRoom(ClassRoom classroom)
        {
            int test = 0;
            var result = db.ClassRooms.SingleOrDefault(b => b.ClassRoomID == classroom.ClassRoomID);
            if (result != null)
            {
                if (classroom.CourseID != null)
                    result.CourseID = classroom.CourseID;
                if (classroom.BuildingID != null)
                    result.BuildingID = classroom.BuildingID;
                if (classroom.RoomNumber != null)
                    result.RoomNumber = classroom.RoomNumber;
                if (classroom.StartClassTime != null)
                    result.StartClassTime = classroom.StartClassTime;
                if (classroom.EndClassTime != null)
                    result.EndClassTime = classroom.EndClassTime;

                test = db.SaveChanges();
            }
            return test > 0;
        }

        public bool updateCourse(Course course)
        {
            int test = 0;
            var result = db.Courses.SingleOrDefault(b => b.CourseID == course.CourseID);
            if (result != null)
            {
                if (course.CourseNumber != 0)
                    result.CourseNumber = course.CourseNumber;
                if (course.ProfessorID != null)
                    result.ProfessorID = course.ProfessorID;
                if (course.BuildingID != null)
                    result.BuildingID = course.BuildingID;
                if (course.CourseName != null)
                    result.CourseName = course.CourseName;
                if (course.maxStudents != null)
                    result.maxStudents = course.maxStudents;
                if (course.StartClassTime != null)
                    result.StartClassTime = course.StartClassTime;
                if (course.EndClassTime != null)
                    result.EndClassTime = course.EndClassTime;
                if (course.CourseFull != null)
                    result.CourseFull = course.CourseFull;

                test = db.SaveChanges();
            }
            return test > 0;
        }


        public bool updateEnrollment(Enrollment enrollment)
        {
            int test = 0;
            var result = db.Enrollments.SingleOrDefault(b => b.EnrollmentID == enrollment.EnrollmentID);
            if (result != null)
            {
                if (enrollment.StudentID != null)
                    result.StudentID = enrollment.StudentID;
                if (enrollment.CourseID != null)
                    result.CourseID = enrollment.CourseID;
                if (enrollment.CourseName != null)
                    result.CourseName = enrollment.CourseName;
                if (enrollment.CourseNumber != null)
                    result.CourseNumber = enrollment.CourseNumber;
                if (enrollment.ClassStartTime != null)
                    result.ClassStartTime = enrollment.ClassStartTime;

                test = db.SaveChanges();
            }
            return test > 0;
        }

        public bool updateProfessor(Professor professor)
        {
            int test = 0;
            var result = db.Professors.SingleOrDefault(b => b.ProfessorID == professor.ProfessorID);
            if (result != null)
            {
                if (professor.Name !=  null)
                    result.Name = professor.Name;
                test = db.SaveChanges();
            }
            return test > 0;
        }

        public bool updateRoom(Room room)
        {
            int test = 0;
            var result = db.Rooms.SingleOrDefault(b => b.RoomID == room.RoomID);
            if (result != null)
            {
                if (room.BuildingID != null)
                    result.BuildingID = room.BuildingID;
                if (room.RoomNumber != null)
                    result.RoomNumber = room.RoomNumber;
                
                test = db.SaveChanges();
            }
            return test > 0;
        }

    }
}
