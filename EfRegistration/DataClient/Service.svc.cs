using EfRegistration;
using RegistrationDataClient.Mappers;
using RegistrationDataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DataClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        private EfInserts InsertData = new EfInserts();
        private EfDelete DeleteData = new EfDelete();
        private EfGetMethods GetData = new EfGetMethods();
        private EfUpdate UpdateData = new EfUpdate();
        private Registrar registrar = new Registrar();

        public List<StudentDAO> GetStudents()
        {
            var data = new List<StudentDAO>();
            foreach (var student in GetData.GetStudents())
            {
                data.Add(StudentMapper.MapToStudentDAO(student));
            }
            return data;
        }

        public List<CourseDAO> GetCourses()
        {
            var data = new List<CourseDAO>();
            foreach (var course in GetData.GetCourses())
            {
                data.Add(CourseMapper.MapToCourseDAO(course));
            }
            return data;
        }

        public bool AddStudent(StudentDAO student)
        {
            var stud = StudentMapper.MapToStudent(student);
            return InsertData.InsertStudent(stud);
        }

        public bool AddCourse(CourseDAO course)
        {
            var c = CourseMapper.MapToCourse(course);
            return InsertData.InsertCourse(c);
        }

        public bool EnrollStudent(StudentDAO student, CourseDAO course)
        {
            Enrollment enroll = new Enrollment();
            enroll.StudentID = student.id;
            enroll.CourseID = course.id;
            enroll.CourseName = course.name;
            enroll.CourseNumber = course.number;
            enroll.ClassStartTime = course.StartClassTime;
            return InsertData.insertEnrollment(enroll);
        }

        public List<CourseDAO> getStudentSchedule(int studentid)
        {
            var data = new List<CourseDAO>();
            foreach (var course in registrar.GetStudentSchedule(studentid))
            {
                data.Add(CourseMapper.MapToCourseDAO(course));
            }
            return data;
        }


        public List<StudentDAO> getCourseRoster(int courseid)
        {
            var data = new List<StudentDAO>();
            foreach (var student in registrar.StudentsEnrolledInCourse(courseid))
            {
                data.Add(StudentMapper.MapToStudentDAO(student));
            }
            return data;
        }
    }
}