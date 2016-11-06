using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Model
{
    [DataContract]
    public class StudentDAO
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Major { get; set; }
        [DataMember]
        public List<CourseDAO> Courses { get; set; }
    }
}
