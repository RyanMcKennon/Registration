using EfRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationTests
{
    public class UpdateTests
    {
        [Fact]
        public void Test_UpdateStudent()
        {
            var data = new EfUpdate();
            var expected = new Student() { StudentID = 5,  Major = "CS", Active = true };
            var actual = data.updateStudent(expected);

            Assert.True(actual);
        }
    }
}
