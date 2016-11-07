using RegistrationWeb.Logic;
using RegistrationWeb.Logic.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWeb.Client
{
    public partial class RegistrarView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void singleStudent(object sender, EventArgs e)
        {
            x.Visible = true;
        }

        public void DisplayEnrolled(object sender, EventArgs e)
        {
            var data = new DataService();
            courselist.Visible = false;
            studentsenrolled_textbox.Visible = true;
            foreach (var student in data.GetRoster(int.Parse(courselist.SelectedValue.ToString())))
            {
                studentsenrolled_textbox.Items.Add(new ListItem() { Text = (student.FirstName + " " + student.LastName) });
            }
        }

        public void ListAllStudents(object sender, EventArgs e)
        {
            studentlist.Items.Clear();
            studentdiv.Visible = true;
            studentlist.Visible = true;
            var data = new DataService();
            var students = data.GetStudents();
            foreach (var item in students)
            {
                studentlist.Items.Add(new ListItem() { Text = (item.FirstName + " " + item.LastName) });
            }
        }

        public void CloseStudentList(object sender, EventArgs e)
        {
            studentlist.Items.Clear();
            studentlist.Visible = false;
            studentdiv.Visible = false;
        }
        public void LoadStudentInfo(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(studentid_text.Text))
            {
                var data = new DataService();
                var stud = data.GetStudentById(int.Parse(studentid_text.Text));
                StudentName.Text = (stud.FirstName + " " + stud.LastName);
                StudentMajor.Text = stud.Major;
            }
            else
            {
                string myStringVariable = "You've entered invalid data";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            }
        }

        public void GetStudentSchedule(object sender, EventArgs e)
        {
            schedule.Items.Clear();
            schedule.Visible = true;
            var data = new DataService();
            var courses = data.GetSchedule(int.Parse(studentid_text.Text));
            foreach (var item in courses)
            {
                schedule.Items.Add(new ListItem() { Text = item.name });
            }
            deletebutton.Visible = true;
        }

        public void CloseSchedule(object sender, EventArgs e)
        {
            schedule.Items.Clear();
            schedule.Visible = false;
            deletebutton.Visible = false;
        }

        public void CloseCourses(object sender, EventArgs e)
        {
            courses.Items.Clear();
            courses.Visible = false;
            insertbutton.Visible = false;
        }

        public void CloseStudentView(object sender, EventArgs e)
        {
            schedule.Items.Clear();
            schedule.Visible = false;
            x.Visible = false;
        }
        public void DropClass(object sender, EventArgs e)
        {
            var sid = int.Parse(studentid_text.Text);
            var courseName = schedule.SelectedItem.ToString();
            var data = new DataService();
            StudentDAO student = new StudentDAO() { id = sid };
            CourseDAO course = new CourseDAO() { name = courseName };
            data.dropCourseFromStudent(student, course);
            schedule.Items.Clear();
            schedule.Visible = false;
            deletebutton.Visible = false;
        }

        public void DisplayCourses(object sender, EventArgs e)
        {
            courses.Items.Clear();
            courses.Visible = true;
            var data = new DataService();
            var AllCourses = data.GetCourses();
            foreach (var item in AllCourses)
            {
                courses.Items.Add(new ListItem() { Text = item.name, Value = item.id.ToString() });
            }
            insertbutton.Visible = true;
        }


        public void ShowCourses(object sender, EventArgs e)
        {
            courselist.Items.Clear();
            studentsenrolled_textbox.Items.Clear();
            coursediv.Visible = true;
            courselist.Visible = true;
            var data = new DataService();
            var AllCourses = data.GetCourses();
            foreach (var item in AllCourses)
            {
                courselist.Items.Add(new ListItem() { Text = item.name, Value = item.id.ToString() });
            }
        }

        public void AddRemoveStudentList(object sender, EventArgs e)
        {
            addremovestudentdiv.Visible = true;
            addremovestudentlist_listbox.Items.Clear();
            studentlist.Items.Clear();
            var data = new DataService();
            var students = data.GetStudents();
            foreach (var item in students)
            {
                addremovestudentlist_listbox.Items.Add(new ListItem() { Text = (item.FirstName + " " + item.LastName), Value=item.id.ToString() });
            }
        }

        public void AddRemoveCourseList(object sender, EventArgs e)
        {
            addremovecourse_div.Visible = true;
            addremovecourse_listbox.Items.Clear();
            var data = new DataService();
            var courses = data.GetCourses();
            foreach(var item in courses)
            {
                addremovecourse_listbox.Items.Add(new ListItem() { Text = item.name, Value = item.id.ToString() });
            }
        }
        public void openAddStudent(object sender, EventArgs e)
        {
            addstudentfields.Visible = true;
        }

        public void openAddCourse(object sender, EventArgs e)
        {
            addcoursefields.Visible = true;
        }

        public void AddStudent(object sender, EventArgs e)
        {
            var data = new DataService();
            StudentDAO stud = new StudentDAO();
            stud.FirstName = firstname_text.Text;
            stud.LastName = lastname_text.Text;
            stud.Major = major_text.Text;

            data.AddStudent(stud);
            firstname_text.Text = string.Empty;
            lastname_text.Text = string.Empty;
            major_text.Text = string.Empty;
            addstudentfields.Visible = false;
            addremovestudentlist_listbox.Items.Clear();
            addremovestudentdiv.Visible = false;
        }

        public void AddCourse(object sender, EventArgs e)
        {
            var data = new DataService();
            CourseDAO course = new CourseDAO();
            course.name = coursename_textbox.Text;
            course.number = int.Parse(coursenumber_textbox.Text);
            course.maxStudents = int.Parse(coursemax_textbox.Text);
            course.StartClassTime = TimeSpan.Parse(starttime_textbox.Text);
            course.EndClassTime = TimeSpan.Parse(endtime_textbox.Text);

            data.AddCourse(course);
            coursename_textbox.Text = string.Empty;
            coursenumber_textbox.Text = string.Empty;
            coursemax_textbox.Text = string.Empty;
            starttime_textbox.Text = string.Empty;
            endtime_textbox.Text = string.Empty;
            addcoursefields.Visible = false;
            addremovecourse_listbox.Items.Clear();
            addremovecourse_div.Visible = false;
        }
        public void RemoveStudent(object sender, EventArgs e)
        {
            var data = new DataService();
            data.DropStudent(int.Parse(addremovestudentlist_listbox.SelectedValue));
            addremovestudentlist_listbox.Items.Clear();
            addremovestudentdiv.Visible = false;
        }

        public void RemoveCourse(object sender, EventArgs e)
        {
            var data = new DataService();
            data.DropCourse(int.Parse(addremovecourse_listbox.SelectedValue));
            addremovecourse_listbox.Items.Clear();
            addremovecourse_div.Visible = false;
        }

        public void closeAddRemoveStudent(object sender, EventArgs e)
        {
            addremovestudentlist_listbox.Items.Clear();
            addremovestudentdiv.Visible = false;
        }
        
        public void closeAddRemoveCourse(object sender, EventArgs e)
        {
            addremovecourse_listbox.Items.Clear();
            addremovecourse_div.Visible = false;
        }
        public void CloseCourseList(object sender,EventArgs e)
        {
            courselist.Items.Clear();
            studentsenrolled_textbox.Items.Clear();
            studentsenrolled_textbox.Visible = false;
            coursediv.Visible = false;
            courselist.Visible = false;
        }

        public void AddClass(object sender, EventArgs e)
        {
            var data = new DataService();

            var sid = int.Parse(studentid_text.Text);
            List<CourseDAO> c = data.GetCourses().Where(x => x.id == int.Parse(courses.SelectedValue)).ToList();
            data.Enroll(new StudentDAO() { id = sid }, new CourseDAO() { id = c[0].id, name = c[0].name, number = c[0].number, StartClassTime = c[0].StartClassTime });
            courses.Items.Clear();
            courses.Visible = false;
            insertbutton.Visible = false;
        }
    }
}