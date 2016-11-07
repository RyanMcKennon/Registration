<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master"  CodeBehind="RegistrarView.aspx.cs" Inherits="RegistrationWeb.Client.RegistrarView" %>


<asp:Content runat="server" ContentPlaceHolderID="body">
    <div>
        <asp:Button runat="server" id="liststudents_button" Text="Show all Students" onclick="ListAllStudents"/>
        <asp:Button runat="server" id="showcourses" Text="Show all courses" OnClick="ShowCourses"/>
        <asp:Button runat="server" id="addstudent_button" Text="Add/Remove Student" OnClick="AddRemoveStudentList"/>
        <asp:Button runat="server" id="addcourse_button" Text="Add/Remove Course" OnClick="AddRemoveCourseList"/>
        <asp:Button runat="server" id="studentinfo_button" Text="View a Student" OnClick="singleStudent"/>
    </div>
    <div>
        <asp:ListBox runat="server" ID="liststudents" Visible="false" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
        <asp:ListBox runat="server" ID="listcourses" Visible="false" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
    </div>
    <div runat="server" visible="false" id="x">
        <asp:Label runat="server" ID="studentid">Enter student ID please</asp:Label> 
        <asp:TextBox runat="server" ID="studentid_text"></asp:TextBox>
        <asp:Button runat="server" ID="submitStudentid" OnClick="LoadStudentInfo" Text="Submit" />
        <div>
            <asp:Label runat="server" ID="StudentName"></asp:Label>
            <asp:Label runat="server" ID="StudentMajor"></asp:Label>

        </div>
        <div>
            <asp:Button runat="server" ID="studentschedule" Text="Schedule" OnClick="GetStudentSchedule" />
            <asp:Button runat="server" ID="closestudentschedule" Text="Close Schedule" OnClick="CloseSchedule" />
            <asp:Button runat="server" ID="avilablecourses" Text="Display courses" onclick="DisplayCourses"/>
            <asp:Button runat="server" ID="closecourselist" Text="Close availble courses"  OnClick="CloseCourses" />
            <asp:Button runat="server" ID="closesinglestudent" Text="Close student viewing" OnClick="CloseStudentView" />
        </div>
        <div>
            <asp:Listbox runat="server" ID="schedule" Visible="false" Font-Size="Medium" Height="400px" Width="500px"></asp:Listbox>
            <asp:ListBox runat="server" ID="courses" Visible ="false" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
        </div>
        <div runat="server" visible="false" id="deletebutton">
        <asp:Button runat="server" ID="delete" Text="drop course" onclick="DropClass"/>
        </div>
        <div runat="server" visible="false" id="insertbutton">
        <asp:Button runat="server" ID="insert" Text="enroll course" onclick="AddClass"/>
        </div>
    </div>


    <div runat="server" visible="false" id="studentdiv">
        <div>
            <asp:ListBox runat="server" ID="studentlist" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
        </div>
        <div>
            <asp:Button runat="server" ID="closestudentlist" Text="Close List" OnClick="CloseStudentList" />
        </div>
    </div>


    <div runat="server" visible="false" id="coursediv">
        <div>
            <asp:ListBox runat="server" ID="courselist" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
            <asp:ListBox runat="server" visible="false" ID="studentsenrolled_textbox" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
        </div>
        <div>
            <asp:Button runat="server" ID="studentsenrolled_button" Text="Show enrolled students" OnClick="DisplayEnrolled" />
            <asp:Button runat="server" ID="closelist" Text="Close List" OnClick="CloseCourseList" />
        </div>
    </div>


    <div runat="server" visible="false" id="addremovestudentdiv">
        <div>
            <asp:ListBox runat="server" ID="addremovestudentlist_listbox" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
        </div>
        <div>
            <asp:Button runat="server" ID="addremovestudentremove" Text="Remove Student" OnClick="RemoveStudent" />
            <asp:Button runat="server" ID="addremovestudentadd" Text="Add Student" onclick="openAddStudent"/>
            <asp:Button runat="server" ID="addremovestudentclose" Text="Close" onclick="closeAddRemoveStudent" />
        </div>
        <div runat="server" visible="false" id="addstudentfields">
            <asp:Label runat="server" ID="firstname_label" Text="Enter First Name"></asp:Label>
            <asp:TextBox runat="server" ID="firstname_text"></asp:TextBox>
            <asp:Label runat="server" ID="lastname_label" Text="Enter Last name"></asp:Label>
            <asp:TextBox runat="server" ID="lastname_text"></asp:TextBox>
            <asp:Label runat="server" ID="major_label" Text="Enter Major"></asp:Label>
            <asp:TextBox runat="server" ID="major_text"></asp:TextBox>
            <asp:Button runat="server" ID="subitstudent_button" Text="Submit" onclick="AddStudent"/>
        </div>
    </div>


    <div runat="server" visible="false" id="addremovecourse_div">
        <div>
            <asp:ListBox runat="server" ID="addremovecourse_listbox" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
        </div>
        <div>
            <asp:Button runat="server" ID="addremovecourseremove" Text="Remove Course" OnClick="RemoveCourse" />
            <asp:Button runat="server" ID="Button2" Text="Add Course" onclick="openAddCourse"/>
            <asp:Button runat="server" ID="closeaddremove_button" Text="Close" onclick="closeAddRemoveCourse" />
        </div>
        <div runat="server" visible="false" id="addcoursefields">
            <asp:Label runat="server" ID="coursename_label" Text="Enter Course name"></asp:Label>
            <asp:TextBox runat="server" ID="coursename_textbox"></asp:TextBox>

            <asp:Label runat="server" ID="coursenumber_label" Text="Enter Course number"></asp:Label>
            <asp:TextBox runat="server" ID="coursenumber_textbox"></asp:TextBox>

            <asp:Label runat="server" ID="coursemax_label" Text="Enter class capacity"></asp:Label>
            <asp:TextBox runat="server" ID="coursemax_textbox"></asp:TextBox>

            <asp:Label runat="server" ID="starttime_label" Text="Enter Class start time"></asp:Label>
            <asp:TextBox runat="server" ID="starttime_textbox"></asp:TextBox>

             <asp:Label runat="server" ID="endtime_label" Text="Enter Class end time"></asp:Label>
            <asp:TextBox runat="server" ID="endtime_textbox"></asp:TextBox>
            <asp:Button runat="server" ID="submitcourse_button" Text="Submit" onclick="AddCourse"/>
        </div>
    </div>



</asp:Content>