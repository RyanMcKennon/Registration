﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationWeb.Logic.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentDAO", Namespace="http://schemas.datacontract.org/2004/07/RegistrationDataClient.Model")]
    [System.SerializableAttribute()]
    public partial class StudentDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RegistrationWeb.Logic.ServiceReference.CourseDAO[] CoursesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MajorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RegistrationWeb.Logic.ServiceReference.CourseDAO[] Courses {
            get {
                return this.CoursesField;
            }
            set {
                if ((object.ReferenceEquals(this.CoursesField, value) != true)) {
                    this.CoursesField = value;
                    this.RaisePropertyChanged("Courses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Major {
            get {
                return this.MajorField;
            }
            set {
                if ((object.ReferenceEquals(this.MajorField, value) != true)) {
                    this.MajorField = value;
                    this.RaisePropertyChanged("Major");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseDAO", Namespace="http://schemas.datacontract.org/2004/07/RegistrationDataClient.Model")]
    [System.SerializableAttribute()]
    public partial class CourseDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan EndClassTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan StartClassTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RegistrationWeb.Logic.ServiceReference.StudentDAO StudentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RegistrationWeb.Logic.ServiceReference.BuildingDAO buildingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int maxStudentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RegistrationWeb.Logic.ServiceReference.ProfessorDAO professorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan EndClassTime {
            get {
                return this.EndClassTimeField;
            }
            set {
                if ((this.EndClassTimeField.Equals(value) != true)) {
                    this.EndClassTimeField = value;
                    this.RaisePropertyChanged("EndClassTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan StartClassTime {
            get {
                return this.StartClassTimeField;
            }
            set {
                if ((this.StartClassTimeField.Equals(value) != true)) {
                    this.StartClassTimeField = value;
                    this.RaisePropertyChanged("StartClassTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RegistrationWeb.Logic.ServiceReference.StudentDAO Student {
            get {
                return this.StudentField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentField, value) != true)) {
                    this.StudentField = value;
                    this.RaisePropertyChanged("Student");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RegistrationWeb.Logic.ServiceReference.BuildingDAO building {
            get {
                return this.buildingField;
            }
            set {
                if ((object.ReferenceEquals(this.buildingField, value) != true)) {
                    this.buildingField = value;
                    this.RaisePropertyChanged("building");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int maxStudents {
            get {
                return this.maxStudentsField;
            }
            set {
                if ((this.maxStudentsField.Equals(value) != true)) {
                    this.maxStudentsField = value;
                    this.RaisePropertyChanged("maxStudents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RegistrationWeb.Logic.ServiceReference.ProfessorDAO professor {
            get {
                return this.professorField;
            }
            set {
                if ((object.ReferenceEquals(this.professorField, value) != true)) {
                    this.professorField = value;
                    this.RaisePropertyChanged("professor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BuildingDAO", Namespace="http://schemas.datacontract.org/2004/07/RegistrationDataClient.Model")]
    [System.SerializableAttribute()]
    public partial class BuildingDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RegistrationWeb.Logic.ServiceReference.RoomDAO[] RoomsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RegistrationWeb.Logic.ServiceReference.RoomDAO[] Rooms {
            get {
                return this.RoomsField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomsField, value) != true)) {
                    this.RoomsField = value;
                    this.RaisePropertyChanged("Rooms");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorDAO", Namespace="http://schemas.datacontract.org/2004/07/RegistrationDataClient.Model")]
    [System.SerializableAttribute()]
    public partial class ProfessorDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RegistrationWeb.Logic.ServiceReference.CourseDAO[] coursesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RegistrationWeb.Logic.ServiceReference.CourseDAO[] courses {
            get {
                return this.coursesField;
            }
            set {
                if ((object.ReferenceEquals(this.coursesField, value) != true)) {
                    this.coursesField = value;
                    this.RaisePropertyChanged("courses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomDAO", Namespace="http://schemas.datacontract.org/2004/07/RegistrationDataClient.Model")]
    [System.SerializableAttribute()]
    public partial class RoomDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RegistrationWeb.Logic.ServiceReference.BuildingDAO BuildingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoomNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RegistrationWeb.Logic.ServiceReference.BuildingDAO Building {
            get {
                return this.BuildingField;
            }
            set {
                if ((object.ReferenceEquals(this.BuildingField, value) != true)) {
                    this.BuildingField = value;
                    this.RaisePropertyChanged("Building");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomNumber {
            get {
                return this.RoomNumberField;
            }
            set {
                if ((this.RoomNumberField.Equals(value) != true)) {
                    this.RoomNumberField = value;
                    this.RaisePropertyChanged("RoomNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudents", ReplyAction="http://tempuri.org/IService/GetStudentsResponse")]
        RegistrationWeb.Logic.ServiceReference.StudentDAO[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudents", ReplyAction="http://tempuri.org/IService/GetStudentsResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.StudentDAO[]> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudentByID", ReplyAction="http://tempuri.org/IService/GetStudentByIDResponse")]
        RegistrationWeb.Logic.ServiceReference.StudentDAO GetStudentByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudentByID", ReplyAction="http://tempuri.org/IService/GetStudentByIDResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.StudentDAO> GetStudentByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCourses", ReplyAction="http://tempuri.org/IService/GetCoursesResponse")]
        RegistrationWeb.Logic.ServiceReference.CourseDAO[] GetCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCourses", ReplyAction="http://tempuri.org/IService/GetCoursesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.CourseDAO[]> GetCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddStudent", ReplyAction="http://tempuri.org/IService/AddStudentResponse")]
        bool AddStudent(RegistrationWeb.Logic.ServiceReference.StudentDAO student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddStudent", ReplyAction="http://tempuri.org/IService/AddStudentResponse")]
        System.Threading.Tasks.Task<bool> AddStudentAsync(RegistrationWeb.Logic.ServiceReference.StudentDAO student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddCourse", ReplyAction="http://tempuri.org/IService/AddCourseResponse")]
        bool AddCourse(RegistrationWeb.Logic.ServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddCourse", ReplyAction="http://tempuri.org/IService/AddCourseResponse")]
        System.Threading.Tasks.Task<bool> AddCourseAsync(RegistrationWeb.Logic.ServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EnrollStudent", ReplyAction="http://tempuri.org/IService/EnrollStudentResponse")]
        bool EnrollStudent(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EnrollStudent", ReplyAction="http://tempuri.org/IService/EnrollStudentResponse")]
        System.Threading.Tasks.Task<bool> EnrollStudentAsync(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getStudentSchedule", ReplyAction="http://tempuri.org/IService/getStudentScheduleResponse")]
        RegistrationWeb.Logic.ServiceReference.CourseDAO[] getStudentSchedule(int studentid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getStudentSchedule", ReplyAction="http://tempuri.org/IService/getStudentScheduleResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.CourseDAO[]> getStudentScheduleAsync(int studentid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCourseRoster", ReplyAction="http://tempuri.org/IService/getCourseRosterResponse")]
        RegistrationWeb.Logic.ServiceReference.StudentDAO[] getCourseRoster(int courseid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCourseRoster", ReplyAction="http://tempuri.org/IService/getCourseRosterResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.StudentDAO[]> getCourseRosterAsync(int courseid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/dropCourseFromStudent", ReplyAction="http://tempuri.org/IService/dropCourseFromStudentResponse")]
        bool dropCourseFromStudent(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/dropCourseFromStudent", ReplyAction="http://tempuri.org/IService/dropCourseFromStudentResponse")]
        System.Threading.Tasks.Task<bool> dropCourseFromStudentAsync(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveStudent", ReplyAction="http://tempuri.org/IService/RemoveStudentResponse")]
        bool RemoveStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveStudent", ReplyAction="http://tempuri.org/IService/RemoveStudentResponse")]
        System.Threading.Tasks.Task<bool> RemoveStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveCourse", ReplyAction="http://tempuri.org/IService/RemoveCourseResponse")]
        bool RemoveCourse(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveCourse", ReplyAction="http://tempuri.org/IService/RemoveCourseResponse")]
        System.Threading.Tasks.Task<bool> RemoveCourseAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ModifyCapacity", ReplyAction="http://tempuri.org/IService/ModifyCapacityResponse")]
        bool ModifyCapacity(int id, int capacity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ModifyCapacity", ReplyAction="http://tempuri.org/IService/ModifyCapacityResponse")]
        System.Threading.Tasks.Task<bool> ModifyCapacityAsync(int id, int capacity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ModifyCourseTime", ReplyAction="http://tempuri.org/IService/ModifyCourseTimeResponse")]
        bool ModifyCourseTime(int id, string startTime, string endTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ModifyCourseTime", ReplyAction="http://tempuri.org/IService/ModifyCourseTimeResponse")]
        System.Threading.Tasks.Task<bool> ModifyCourseTimeAsync(int id, string startTime, string endTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : RegistrationWeb.Logic.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<RegistrationWeb.Logic.ServiceReference.IService>, RegistrationWeb.Logic.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RegistrationWeb.Logic.ServiceReference.StudentDAO[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.StudentDAO[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
        
        public RegistrationWeb.Logic.ServiceReference.StudentDAO GetStudentByID(int id) {
            return base.Channel.GetStudentByID(id);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.StudentDAO> GetStudentByIDAsync(int id) {
            return base.Channel.GetStudentByIDAsync(id);
        }
        
        public RegistrationWeb.Logic.ServiceReference.CourseDAO[] GetCourses() {
            return base.Channel.GetCourses();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.CourseDAO[]> GetCoursesAsync() {
            return base.Channel.GetCoursesAsync();
        }
        
        public bool AddStudent(RegistrationWeb.Logic.ServiceReference.StudentDAO student) {
            return base.Channel.AddStudent(student);
        }
        
        public System.Threading.Tasks.Task<bool> AddStudentAsync(RegistrationWeb.Logic.ServiceReference.StudentDAO student) {
            return base.Channel.AddStudentAsync(student);
        }
        
        public bool AddCourse(RegistrationWeb.Logic.ServiceReference.CourseDAO course) {
            return base.Channel.AddCourse(course);
        }
        
        public System.Threading.Tasks.Task<bool> AddCourseAsync(RegistrationWeb.Logic.ServiceReference.CourseDAO course) {
            return base.Channel.AddCourseAsync(course);
        }
        
        public bool EnrollStudent(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course) {
            return base.Channel.EnrollStudent(student, course);
        }
        
        public System.Threading.Tasks.Task<bool> EnrollStudentAsync(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course) {
            return base.Channel.EnrollStudentAsync(student, course);
        }
        
        public RegistrationWeb.Logic.ServiceReference.CourseDAO[] getStudentSchedule(int studentid) {
            return base.Channel.getStudentSchedule(studentid);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.CourseDAO[]> getStudentScheduleAsync(int studentid) {
            return base.Channel.getStudentScheduleAsync(studentid);
        }
        
        public RegistrationWeb.Logic.ServiceReference.StudentDAO[] getCourseRoster(int courseid) {
            return base.Channel.getCourseRoster(courseid);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.ServiceReference.StudentDAO[]> getCourseRosterAsync(int courseid) {
            return base.Channel.getCourseRosterAsync(courseid);
        }
        
        public bool dropCourseFromStudent(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course) {
            return base.Channel.dropCourseFromStudent(student, course);
        }
        
        public System.Threading.Tasks.Task<bool> dropCourseFromStudentAsync(RegistrationWeb.Logic.ServiceReference.StudentDAO student, RegistrationWeb.Logic.ServiceReference.CourseDAO course) {
            return base.Channel.dropCourseFromStudentAsync(student, course);
        }
        
        public bool RemoveStudent(int id) {
            return base.Channel.RemoveStudent(id);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveStudentAsync(int id) {
            return base.Channel.RemoveStudentAsync(id);
        }
        
        public bool RemoveCourse(int id) {
            return base.Channel.RemoveCourse(id);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveCourseAsync(int id) {
            return base.Channel.RemoveCourseAsync(id);
        }
        
        public bool ModifyCapacity(int id, int capacity) {
            return base.Channel.ModifyCapacity(id, capacity);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyCapacityAsync(int id, int capacity) {
            return base.Channel.ModifyCapacityAsync(id, capacity);
        }
        
        public bool ModifyCourseTime(int id, string startTime, string endTime) {
            return base.Channel.ModifyCourseTime(id, startTime, endTime);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyCourseTimeAsync(int id, string startTime, string endTime) {
            return base.Channel.ModifyCourseTimeAsync(id, startTime, endTime);
        }
    }
}
