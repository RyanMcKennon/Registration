using EfRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationTests
{
    public class GetTests
    {
        [Fact]
        public void Test_GetStudents()
        {
            var data = new EfGetMethods();
            var actual = data.GetStudents();

            Assert.NotEmpty(actual);
        }
    }
}
