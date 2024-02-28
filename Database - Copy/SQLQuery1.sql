

create database School_management

on primary (
Name = School_management_date,
fileName ='D:\Prg\C#\School management system\Database\School_management_date.mdf',
size = 6mb,
MaxSize=8MB,
FileGrowth=4MB  )

Log on(
name= School_management_Log,
filename='D:\Prg\C#\School management system\Database\School_management_Log.Ldf',
Size=6MB,
MaxSize=8MB,
FileGrowth=4MB  )




CREATE TABLE Class(
	Class_num int primary key,
	Class_name varchar(150) NOT NULL,
	Class_Room int
) 

CREATE TABLE Student(
	Studen_id varchar(50) primary key,
	Student_fname varchar(150) NOT NULL,
	Student_lname varchar(150) NOT NULL ,
	Student_pic varbinary(max),
	Gender  varchar(50) NOT NULL CHECK (gender in('Male','Female')),
	Date_birth datetime,
	Mobile varchar(50) ,
	Email varchar(150),
	Join_date datetime NOT NULL,
	Adress varchar(150),
	num_class int ,
	constraint fk_class_student foreign key (num_class) references Class (Class_num)
	on update cascade
    on delete cascade
)
CREATE TABLE Subject_(
	Subject_id int primary key,
	Subject_name nvarchar(50) NOT NULL 

)

CREATE TABLE Teacher(
	Teacher_id varchar(50) primary key,
	Teacher_fname varchar(150) NOT NULL,
	Teacher_lname varchar(150) NOT NULL ,
	Teacher_pic varbinary(max),
	Mobile varchar(50),
	Email varchar(150) NOT  NULL,
	Password_ varchar (50) NOT  NULL,
	Join_dat  datetime NOT NULL,
    num_class int ,
	id_subject int,
	constraint fk_class_teacher foreign key (num_class) references Class (Class_num),
	constraint fk_subject_teacher foreign key (id_subject) references Subject_ (Subject_id)
	on update cascade
    on delete cascade
)


CREATE TABLE Exam(
       id_student varchar(50) ,
	   id_subject int,
	   Date_ datetime,
	   Grade int,
	constraint fk_student_exam foreign key (id_student) references Student (Studen_id) ,
	constraint fk_subject_exam foreign key (id_subject) references Subject_(Subject_id)
	on update cascade
    on delete cascade
) 
-------------------- INSSERT -------------------------
INSERT INTO Class(Class_num,class_name,Class_Room)
     VALUES(1,'class 1 fachinformatiker',1)

INSERT INTO Subject_(subject_id,Subject_name)
     VALUES('1','Math')

INSERT INTO Teacher(Teacher_id,Teacher_fname,Teacher_lname,Teacher_pic,Mobile,Email,Password_,Join_dat,num_class,id_subject)
     VALUES('N100','Teacher1','Teacher1',(SELECT * FROM OPENROWSET(BULK N'D:\Prg\C#\School management system\References\Teacher1.png', SINGLE_BLOB) as T1),'0666666666666','Teacher1@gmail.com','Teacher1',02/02/2020,1,1)

INSERT INTO Student (Studen_id, Student_fname, Student_lname, Student_pic, Gender, Date_birth, Mobile, Email,Join_date, Adress, num_class) 
     VALUES (N'D1', N'Student1', N'Student1', (SELECT * FROM OPENROWSET(BULK N'D:\Prg\C#\School management system\References\Student.png', SINGLE_BLOB) as S1), N'Male', N'2000-02-03 00:00:00', N'0111111111', N'0111@gmail:com', N'2024-02-01 00:00:00', N'011111111', 1)
INSERT INTO Student (Studen_id, Student_fname, Student_lname, Student_pic, Gender, Date_birth, Mobile, Email,Join_date, Adress, num_class)  
    VALUES (N'D2', N'Student2', N'Student2', (SELECT * FROM OPENROWSET(BULK N'D:\Prg\C#\School management system\References\Student.png', SINGLE_BLOB) as S1), N'Female', N'2000-02-03 00:00:00', N'0222222222', N'0222@gmail:com', N'2024-02-01 00:00:00', N'022222222', 1)
INSERT INTO Student (Studen_id, Student_fname, Student_lname, Student_pic, Gender, Date_birth, Mobile, Email,Join_date, Adress, num_class)
        VALUES (N'D3', N'Student3', N'Student3', (SELECT * FROM OPENROWSET(BULK N'D:\Prg\C#\School management system\References\Student.png', SINGLE_BLOB) as S1), N'Female', N'2000-02-03 00:00:00', N'0222222222', N'0222@gmail:com', N'2024-02-01 00:00:00', N'022222222', 1)
INSERT INTO Student (Studen_id, Student_fname, Student_lname, Student_pic, Gender, Date_birth, Mobile, Email,Join_date, Adress, num_class) 
      VALUES  (N'D4', N'Student4', N'Student4',(SELECT * FROM OPENROWSET(BULK N'D:\Prg\C#\School management system\References\Student.png', SINGLE_BLOB) as S1), N'Female', N'2000-02-03 00:00:00', N'0222222222', N'0222@gmail:com', N'2024-02-01 00:00:00', N'022222222', 1)
INSERT INTO Student (Studen_id, Student_fname, Student_lname, Student_pic, Gender, Date_birth, Mobile, Email,Join_date, Adress, num_class)
      VALUES (N'D5', N'Student5', N'Student5', (SELECT * FROM OPENROWSET(BULK N'D:\Prg\C#\School management system\References\Student.png', SINGLE_BLOB) as S1), N'Male', N'2000-02-03 00:00:00', N'0222222222', N'0222@gmail:com', N'2024-02-01 00:00:00', N'022222222', 1)


INSERT INTO Exam (id_student, id_subject, Date_, Grade) 
	 VALUES ('D1', 1, '2024-02-21', 19)
INSERT INTO Exam (id_student, id_subject, Date_, Grade) 
	 VALUES (N'D2', 1, N'2024-02-21 00:00:00', 18)
INSERT INTO Exam (id_student, id_subject, Date_, Grade) 
	 VALUES (N'D3', 1, N'2024-02-18 00:00:00', 16)
INSERT INTO Exam (id_student, id_subject, Date_, Grade) 
	 VALUES (N'D4', 1, N'2024-02-21 00:00:00', 0)

