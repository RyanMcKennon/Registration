using EfRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationTests
{
    public  class InsertTests
    {
        [Fact]
        public void Test_StudentInsert()
        {
            var data = new EfInserts();
            var expected = new Student() { StudentFirstName = "Mike", StudentLastName = "Jones", Major = "Math" };
            var actual = data.InsertStudent(expected);

            Assert.True(actual);
        }

        [Fact]
        public void Test_ProfessorInsert()
        {
            var data = new EfInserts();
            var expected = new Professor() { Name = "James" };
            var actual = data.InsertProfessor(expected);

            Assert.True(actual);
        }

        [Fact]
        public void Test_BuildingInsert()
        {
            var data = new EfInserts();
            var expected = new Building() { BuildingName = "Maryjane" };
            var actual = data.InsertBuilding(expected);

            Assert.True(actual);
        }


        [Fact]
        public void Test_RoomInsert()
        {
            var data = new EfInserts();
            var expected = new Room() { BuildingID = 1, RoomNumber = 101 };
            var actual = data.InsertRoom(expected);

            Assert.True(actual);
        }


        [Fact]
        public void Test_CourseInsert()
        {
            var data = new EfInserts();
            var expected = new Course() { CourseName = "Math", CourseNumber = 1101, ProfessorID = 1, BuildingID = 1, StartClassTime = TimeSpan.Parse("2:00"), EndClassTime = TimeSpan.Parse("2:50")};
            var actual = data.InsertCourse(expected);

            Assert.True(actual);
        }

        [Fact]
        public void Test_ClassRoomInsert()
        {
            var data = new EfInserts();
            var expected = new ClassRoom() {CourseID = 1, BuildingID = 1, RoomNumber = 101, StartClassTime = TimeSpan.Parse("2:00"), EndClassTime = TimeSpan.Parse("2:50") };
            var actual = data.InsertClassRoom(expected);

            Assert.True(actual);
        }
        [Fact]
        public void Test_EnrollmentInsert()
        {
            var data = new EfInserts();
            var expected = new Enrollment() { StudentID = 2, CourseID = 1, CourseName = "Math", CourseNumber = 1101, ClassStartTime = TimeSpan.Parse("2:00") };
            var actual = data.insertEnrollment(expected);

            Assert.False(actual);
        }

    }
}
