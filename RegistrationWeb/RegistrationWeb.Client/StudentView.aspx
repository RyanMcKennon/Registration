<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="StudentView.aspx.cs" Inherits="RegistrationWeb.Client.StudentView" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
    <div> 
        <asp:Label runat="server" ID="studentid">Enter your student ID please</asp:Label> 
        <asp:TextBox runat="server" ID="studentid_text"></asp:TextBox>
        <asp:Button runat="server" ID="submitStudentid" OnClick="LoadStudentInfo" Text="Submit" />
    </div>

    <div>
        <asp:Label runat="server" ID="StudentName"></asp:Label>
    </div>
    <div>
        <asp:Button runat="server" ID="studentschedule" Text="Schedule" OnClick="GetStudentSchedule" />
        <asp:Button runat="server" ID="closestudentschedule" Text="Close Schedule" OnClick="CloseSchedule" />
        <asp:Button runat="server" ID="avilablecourses" Text="Display courses" onclick="DisplayCourses"/>
        <asp:Button runat="server" ID="closecourselist" Text="Close availble courses"  OnClick="CloseCourses" />

    </div>
    <div>
        <asp:Listbox runat="server" ID="schedule" Visible="false" Font-Size="Medium" Height="400px" Width="500px"></asp:Listbox>
        <asp:ListBox runat="server" ID="courses" Visible ="false" Font-Size="Medium" Height="400px" Width="500px"></asp:ListBox>
    </div>
    <div runat="server" visible="false" id="insertbutton">
        <asp:Button runat="server" ID="insert" Text="enroll course"  onclick="AddClass"/>
    </div>
    <div runat="server" visible="false" id="deletebutton">
        <asp:Button runat="server" ID="delete" Text="drop course" onclick="DropClass"/>
    </div>

</asp:Content> 
