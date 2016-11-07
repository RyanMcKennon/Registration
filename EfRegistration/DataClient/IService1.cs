using RegistrationDataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DataClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<StudentDAO> GetStudents();

        [OperationContract]
        StudentDAO GetStudentByID(int id);

        [OperationContract]
        List<CourseDAO> GetCourses();

        [OperationContract]
        bool AddStudent(StudentDAO student);

        [OperationContract]
        bool AddCourse(CourseDAO course);

        [OperationContract]
        bool EnrollStudent(StudentDAO student, CourseDAO course);

        [OperationContract]
        List<CourseDAO> getStudentSchedule(int studentid);

        [OperationContract]
        List<StudentDAO> getCourseRoster(int courseid);

        [OperationContract]
        bool dropCourseFromStudent(StudentDAO student, CourseDAO course);

        [OperationContract]
        bool RemoveStudent(int id);

        [OperationContract]
        bool RemoveCourse(int id);
    }
}
