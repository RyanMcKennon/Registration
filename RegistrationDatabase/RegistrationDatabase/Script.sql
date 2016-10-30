create schema Registration;
go

create table Registration.Student(
    StudentID int not null identity(1,1) primary key, 
    StudentFirstName nvarchar(max),
    StudentLastName nvarchar(max), 
    Major nvarchar(max)
);
go

create table Registration.Professor(
    ProfessorID int identity (1,1) primary key,
    Name nvarchar(max)
);
go

create table Registration.Building(
    BuildingID int identity(1,1) primary key,
    BuildingName nvarchar(max)
);
go

create table Registration.Course(
    CourseID int not null identity(1,1) primary key,
    CouseNumber int not null, 
    ProfessorID int,
    BuildingID int,
    CourseName nvarchar(max) not null,
    StartClassTime time not null,
    EndClassTime  time not null,
    CONSTRAINT FK_Registraton_Professor FOREIGN KEY (ProfessorId) REFERENCES Registration.Professor (ProfessorID),
    CONSTRAINT FK_Registraton_Building FOREIGN KEY (BuildingId) REFERENCES Registration.Building (BuildingID)
);
go

create table Registration.ClassRoom(
    ClassRoomID int unique(BuildingID,RoomNumber,StartClassTime),
    CourseID int,
    BuildingID int,
    RoomNumber int,
    StartClassTime time,
    EndClassTime time,
    CONSTRAINT FK_Registraton_CourseID FOREIGN KEY (CourseID) REFERENCES Registration.Course (CourseID),
    CONSTRAINT FK_Registraton_BuildingID FOREIGN KEY (BuildingID) REFERENCES Registration.Building (BuildingID)
);
go

create table Registration.Enrollment(
    StudentID int,
    CourseID int,
    CourseName nvarchar(max),
    CourseNumber int,
    ClassStartTime time,
    CONSTRAINT FK_Registraton_StudentID FOREIGN KEY (StudentID) REFERENCES Registration.Student (StudentID),
    CONSTRAINT FK_Registraton_CourseID_Forentrollment FOREIGN KEY (CourseID) REFERENCES Registration.Course (CourseID)
);
go


create table Registration.Room(
    BuildingID int,
    RoomNumber int
    CONSTRAINT FK_Registraton_Room FOREIGN KEY (BuildingID) REFERENCES Registration.Building (BuildingID)
);
go

