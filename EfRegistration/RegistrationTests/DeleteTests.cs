using EfRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationTests
{
    public class DeleteTests
    {   
        [Fact]
        public void Test_DeleteStudent()
        {
            var data = new EfDelete();
            var expected = 1;
            var actual = data.deleteStudent(expected);

            Assert.True(actual);
        }
        
    }
}
