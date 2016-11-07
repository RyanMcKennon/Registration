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
    public partial class StudentView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void LoadStudentInfo(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(studentid_text.Text))
            {
                var data = new DataService();
                var stud = data.GetStudentById(int.Parse(studentid_text.Text));
                StudentName.Text = (stud.FirstName + " " + stud.LastName);
            }
            else
            {
                string myStringVariable = "You've entered invalid data";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            }

        }

        public void GetStudentSchedule(object sender,EventArgs e)
        {
            schedule.Items.Clear();
            schedule.Visible = true;
            var data = new DataService();
            var courses = data.GetSchedule(int.Parse(studentid_text.Text));
            foreach (var item in courses)
            {
                schedule.Items.Add(new ListItem() { Text = item.name, Value = item.id.ToString()});
            }
            deletebutton.Visible = true;
        }

        public void CloseSchedule(object sender,EventArgs e)
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

        public void DisplayCourses(object sender, EventArgs e)
        {
            courses.Visible = true;
            var data = new DataService();
            var AllCourses = data.GetCourses();
            foreach (var item in AllCourses)
            {
                courses.Items.Add(new ListItem() { Text = item.name, Value=item.id.ToString() });
            }
            insertbutton.Visible = true;
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
    }
}