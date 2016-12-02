using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRegistration
{
    //trying push
    //to do
    // make a bookmark feature later in the UI
    public class StudentFunctions
    {
        //bookmark
        //drop course
        //add course
        private RegistrationDBEntities db = new RegistrationDBEntities();

        public bool AddCourse(Student student, Course course)
        {
            EfInserts data = new EfInserts();
            Enrollment enroll = new Enrollment();
            enroll.CourseNumber = course.CourseNumber;
            enroll.CourseName = course.CourseName;
            enroll.CourseID = course.CourseID;
            enroll.ClassStartTime = course.StartClassTime;
            enroll.StudentID = student.StudentID;

            return data.insertEnrollment(enroll);
        }

        public bool dropCourse(Student student, Course course)
        {
            EfDelete data = new EfDelete();
            Enrollment enroll = new Enrollment();
            enroll.StudentID = student.StudentID;
            enroll.CourseName = course.CourseName;
            var enrollmentToDrop = db.Enrollments.FirstOrDefault(x => x.StudentID == enroll.StudentID && x.CourseName == enroll.CourseName);
            return data.deleteEnrollment(enrollmentToDrop.EnrollmentID);
        }
        

    }
}
