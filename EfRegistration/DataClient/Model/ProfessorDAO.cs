using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Model
{
    [DataContract]
    public class ProfessorDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public List<CourseDAO> courses { get; set; }
    }
}
