using EfRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationTests
{
    public class RegistrarTest
    {
        [Fact]
        public void Test_GetCourseByID()
        {
            var data = new Registrar();
            var expected = new Course() { CourseID = 3 };
            var actual = data.GetCourseByID(3);

            Assert.Equal(expected.CourseID, actual.CourseID);
        }


        [Fact]
        public void Test_GetAllFullCourses()
        {
            var data = new Registrar();
            var expected = 2;
            var actual = data.GetAllFullCourses().Count();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_GetAllClosedCourses()
        {
            var data = new Registrar();
            var expected = 3;
            var actual = data.GetAllClosedCourses().Count();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_GetAllOpenCourses()
        {
            var data = new Registrar();
            var expected = 3;
            var actual = data.GetAllOpenCourses().Count();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_ScheduleCourse()
        {
            var data = new Registrar();
            var actual = data.ScheduleCourse("Comp sci", 2345, 1, 2, 25, "4:00", "4:50", false, true);
            Assert.True(actual);
        }


        [Fact]
        public void Test_CancelCourse()
        {
            var data = new Registrar();
            var expected = 3;
            var actual = data.CancelCourse(expected);

            Assert.True(actual);
        }

        [Fact]
        public void Test_StudentsEnrolledInCourse()
        {
            var data = new Registrar();
            var expected = 1;
            var actual = data.StudentsEnrolledInCourse(1);

            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void Test_GetStudentSchedule()
        {
            var data = new Registrar();
            var expected = 1;
            var actual = data.GetStudentSchedule(6);

            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void Test_AddStudent()
        {
            var data = new Registrar();
            var actual = data.AddStudent("Kyle", "James", "Science", true);

            Assert.True(actual);
        }

        [Fact]
        public void Test_RemoveStudent()
        {
            
        }
    }
}
