using EfRegistration;
using RegistrationDataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Mappers
{
    public class CourseMapper
    {

        public static CourseDAO MapToCourseDAO(Course course)
        {
            var c = new CourseDAO();
            c.id = course.CourseID;
            c.name = course.CourseName;
            c.number = course.CourseNumber;
            c.maxStudents = course.maxStudents.Value;
            c.StartClassTime = course.StartClassTime;
            c.EndClassTime = course.EndClassTime;

            return c;
        }


        public static Course MapToCourse(CourseDAO course)
        {
            var c = new Course();
            c.CourseID = course.id;
            c.CourseName = course.name;
            c.CourseNumber = course.number;
            c.maxStudents = course.maxStudents;
            c.StartClassTime = course.StartClassTime;
            c.EndClassTime = course.EndClassTime;

            return c;
        }
    }
}
