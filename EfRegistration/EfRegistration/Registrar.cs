﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRegistration
{
    public class Registrar
    {
        private RegistrationDBEntities db = new RegistrationDBEntities();

        public bool ModifyCapacity(int id, int capacity)
        {
            Course course = new Course() { CourseID = id, maxStudents = capacity };
            var data = new EfUpdate();
            return data.updateCourse(course);
        }

        public bool ModifyCourseTime(int id, string startTime, string endTime)
        {
            Course course = new Course() { CourseID = id, StartClassTime = TimeSpan.Parse(startTime), EndClassTime = TimeSpan.Parse(endTime)};
            var data = new EfUpdate();
            return data.updateCourse(course);
        }

        public Course GetCourseByID(int id)
        {
            Course course = new Course();
            var result = db.Courses.SingleOrDefault(x => x.CourseID == id);
            if(result != null)
            {
                course.CourseID = result.CourseID;
                course.CourseName = result.CourseName;
                course.CourseNumber = result.CourseNumber;
                course.ProfessorID = result.ProfessorID;
                course.BuildingID = result.BuildingID;
                course.maxStudents = result.maxStudents;
                course.StartClassTime = result.StartClassTime;
                course.EndClassTime = result.EndClassTime;
                course.CourseFull = result.CourseFull;
                course.Active = result.Active;
            }
            return course;
        }


        public List<Course> GetAllFullCourses()
        {
            return db.Courses.Where(x => x.CourseFull == true).ToList();
        }

        public List<Course> GetAllClosedCourses()
        {
            return db.Courses.Where(x => x.CourseFull == true  || x.Active == false).ToList();
        }

        public List<Course> GetAllOpenCourses()
        {
            return db.Courses.Where(x => x.CourseFull == false && x.Active == true).ToList();
        }

        public bool ScheduleCourse(string CourseName, int CourseNumber,int ProfessorID, int BuildingID, int maxStudents, string StartTime, string EndTime, bool CourseFull, bool Active)
        {
            var data = new EfInserts();
            Course course = new Course()
            {
                CourseName = CourseName,
                CourseNumber = CourseNumber,
                ProfessorID = ProfessorID,
                BuildingID = BuildingID,
                maxStudents = maxStudents,
                StartClassTime = TimeSpan.Parse(StartTime),
                EndClassTime = TimeSpan.Parse(EndTime),
                CourseFull = CourseFull,
                Active = Active
            };
            return data.InsertCourse(course);
        }

        public bool CancelCourse(int id)
        {
            var data = new EfDelete();
            return data.deleteCourse(id);
        }

        public List<Student> StudentsEnrolledInCourse(int id)
        {
            var result = db.Enrollments.Join(db.Students,
                                            enroll   => enroll.StudentID,
                                            stud     => stud.StudentID,
                                            (Enrollment,Student) => new {Enrollment = Enrollment, Student = Student})
                                            .Where(x => x.Enrollment.CourseID == id).ToList();

            List<Student> studentsInCourse = new List<Student>();

            for(int i = 0; i< result.Count; i++)
            {
                studentsInCourse.Add(new Student() {
                    StudentID = result[i].Student.StudentID,
                    StudentFirstName = result[i].Student.StudentFirstName,
                    StudentLastName = result[i].Student.StudentLastName,
                    Major = result[i].Student.Major,
                    Active = result[i].Student.Active});
                
            }
            return studentsInCourse;
        }
    }
}
