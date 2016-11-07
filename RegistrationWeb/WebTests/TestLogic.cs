using RegistrationWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebTests
{
    public class TestLogic
    {
        [Fact]
        public void Test_GetStudents()
        {
            var data = new DataService();
            var expected = 1;
            var actual = data.GetStudents();

            Assert.NotEmpty(actual);
        }
    }
}
