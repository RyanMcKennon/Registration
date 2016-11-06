using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Model
{
    [DataContract]
    public class CourseDAO
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public int maxStudents { get; set; }
        [DataMember]
        public TimeSpan StartClassTime { get; set; }
        [DataMember]
        public TimeSpan EndClassTime { get; set; }
        [DataMember]
        public StudentDAO Student { get; set; }
        [DataMember]
        public BuildingDAO building { get; set; }
        [DataMember]
        public ProfessorDAO professor { get; set; }


    }
}
