using RegistrationWeb.Logic.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWeb.Logic
{
    public class DataService
    {
        private ServiceClient sc = new ServiceClient();

        public List<StudentDAO> GetStudents()
        {
            var data = sc.GetStudents().ToList();
            return data;
        }

        public StudentDAO GetStudentById(int id)
        {
            return sc.GetStudentByID(id);
        }


        public List<CourseDAO> GetCourses()
        {
            return sc.GetCourses().ToList();
        }

        public bool AddStudent(StudentDAO student)
        {
            return sc.AddStudent(student);
        }

        public bool AddCourse(CourseDAO course)
        {
            return sc.AddCourse(course);
        }

        public bool Enroll(StudentDAO stud, CourseDAO course)
        {
            return sc.EnrollStudent(stud, course);
        }

        public List<CourseDAO> GetSchedule(int id)
        {
            return sc.getStudentSchedule(id).ToList();
        }

        public List<StudentDAO> GetRoster(int id)
        {
            return sc.getCourseRoster(id).ToList();
        }

        public bool dropCourseFromStudent(StudentDAO student, CourseDAO course)
        {
            return sc.dropCourseFromStudent(student, course);
        }

        public bool DropStudent(int id)
        {
            return sc.RemoveStudent(id);
        }

        public bool DropCourse(int id)
        {
            return sc.RemoveCourse(id);
        }

        public bool ModifyCapacity(int id, int capacity)
        {
            return sc.ModifyCapacity(id, capacity);
        }

        public bool ModifyTime(int id, string startTime, string endTime)
        {
            return sc.ModifyCourseTime(id, startTime, endTime);
        }
    }
}
