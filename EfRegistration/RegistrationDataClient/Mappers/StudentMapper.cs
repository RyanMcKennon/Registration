using EfRegistration;
using RegistrationDataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Mappers
{
    public class StudentMapper
    {
        public static StudentDAO MapToStudentDAO (Student student)
        {
            var stud = new StudentDAO();
            stud.id = student.StudentID;
            stud.FirstName = student.StudentFirstName;
            stud.LastName = student.StudentLastName;
            stud.Major = student.Major;
            return stud;
        }

        public static Student MapToStudent (StudentDAO student)
        {
            var stud = new Student();
            stud.StudentID = student.id;
            stud.StudentFirstName = student.FirstName;
            stud.StudentLastName = student.LastName;
            stud.Major = student.Major;
            return stud;
        }
    }
}
