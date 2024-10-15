	CREATE DATABASE ATTENDANCE
	USE ATTENDANCE;			

	CREATE TABLE User_tbl		
	(
		UserID INT IDENTITY(1,1),
		UserName VARCHAR(35) NOT NULL,
		UserPassword VARCHAR(15) NOT NULL,
		Rols VARCHAR(35) NOT NULL,
		PRIMARY KEY (UserID),
	
	);
	CREATE TABLE Student_tbl
	(
		StudentID INT IDENTITY(1,1) PRIMARY KEY,
		ClassID INT,
		FirstName VARCHAR(50)NOT NULL,
		LastName VARCHAR(50) NOT NULL,
		Class VARCHAR(50) NOT NULL,
		Section VARCHAR(50) NOT NULL,
		DateOfBirth DATE NOT NULL,
		Contact VARCHAR(20) NOT NULL,

		CONSTRAINT Fk_Class FOREIGN KEY(ClassID) REFERENCES Class_tbl(ClassID)
		 
	);
	CREATE TABLE Teacher_tbl
	(
		TeacherID INT IDENTITY(1,1) PRIMARY KEY,
		FirstName VARCHAR(30) NOT NULL,
		Phone VARCHAR(30) NOT NULL,
		Email VARCHAR(255) NOT NULL UNIQUE,
		HireDate DATE,
		
	);
	CREATE TABLE Subject_tbl
	(
		SubjectID INT IDENTITY(1,1) PRIMARY KEY ,
		SubjectName VARCHAR(50) NOT NULL,
		ClassID INT,
		   CONSTRAINT Fk_Subject FOREIGN KEY(ClassID) REFERENCES Class_tbl(ClassID)

	);
	CREATE TABLE Time_tbl
	(
		TimeID INT IDENTITY(1,1) PRIMARY KEY,
		ClassID INT,
		SubjectID INT,
		DayOfWeeks DATE, 
		StartTime TIME, 
		EndTime TIME,
		  
          CONSTRAINT chk_StartTimeEndTime CHECK (StartTime < EndTime), 
		  CONSTRAINT Fk_Time FOREIGN KEY(ClassID) REFERENCES Class_tbl(ClassID),
		  CONSTRAINT Fk_Subject_time FOREIGN KEY(SubjectID) REFERENCES Subject_tbl(SubjectID)

	);
	CREATE TABLE Grade_tbl
	(
		GradeID INT IDENTITY(1,1) PRIMARY KEY,
		StudentID INT,
		SubjectID INT,
		Score INT,
		  CONSTRAINT Fk_Student FOREIGN KEY(StudentID) REFERENCES Student_tbl(StudentID),
		  CONSTRAINT Fk_Subject_Grade FOREIGN KEY(SubjectID) REFERENCES Subject_tbl(SubjectID)

	);
	CREATE TABLE Class_tbl
	(
		ClassID INT IDENTITY(1,1) PRIMARY KEY,
		ClassName VARCHAR(30) NOT NULL,
		Section INT
	);
	CREATE TABLE Attendance_tbl
	(
		AttendanceID INT IDENTITY(1,1) PRIMARY KEY,
		StudentID INT,
		AttendanceDate DATE,
		StatusAttendance VARCHAR(30),
		Remarks VARCHAR(100),

         CONSTRAINT chk_StatusAttendance CHECK (StatusAttendance IN ('Present', 'Absent', 'Late')),
		 CONSTRAINT Fk_Student_Attendance FOREIGN KEY(StudentID) REFERENCES Student_tbl(StudentID)

	);
	--Procedure Base
	IF OBJECT_ID('dbo.AddAttendance', 'P') IS NOT NULL
       DROP PROCEDURE dbo.AddAttendance;
    GO
	CREATE PROCEDURE [dbo].[AddAttendance]
		@StudentID INT,
		@AttendanceDate DATE,
		@StatusAttendance VARCHAR(30),
		@Remarks VARCHAR(100)
	AS
		BEGIN
			 INSERT INTO Attendance_tbl (StudentID, AttendanceDate, StatusAttendance,Remarks) 
			 VALUES (@StudentID, @AttendanceDate, @StatusAttendance,@Remarks);
	END;
    GO

	IF OBJECT_ID('dbo.AddClass', 'P') IS NOT NULL
      DROP PROCEDURE dbo.AddClass;
    GO
	CREATE PROCEDURE [dbo].[AddClass]
		@UserName VARCHAR(35),
		@UserPassword VARCHAR(15),
		@Rols VARCHAR(35) 
	AS
		BEGIN
			 INSERT INTO User_tbl (UserName, UserPassword, Rols) 
			 VALUES (@UserName, @UserPassword, @Rols);
	END;
    GO
	IF OBJECT_ID('dbo.AddTeacher', 'P') IS NOT NULL
      DROP PROCEDURE dbo.AddTeacher;
    GO
	CREATE PROCEDURE [dbo].[AddTeacher]
		@FirstName VARCHAR(30),
		@Phone VARCHAR(30),
		@Email VARCHAR(255),
		@HireDate DATE
	AS
		BEGIN
			 INSERT INTO Teacher_tbl (FirstName, Phone, Email,HireDate) 
			 VALUES (@FirstName, @Phone, @Email,@HireDate);
	END;
	GO

	IF OBJECT_ID('dbo.AddStudent', 'P') IS NOT NULL
      DROP PROCEDURE dbo.AddStudent;
    GO
	CREATE PROCEDURE [dbo].[AddStudent]
		@FirstName VARCHAR(50),
		@LastName VARCHAR(50),
		@Class VARCHAR(50),
		@Section VARCHAR(50),
		@DateOfBirth DATE ,
		@Contact VARCHAR(20)
	AS
		BEGIN
			 INSERT INTO Student_tbl(FirstName, LastName, Class,Section,DateOfBirth,Contact) 
			 VALUES (@FirstName, @LastName, @Class,@Section,@DateOfBirth,@Contact);
	END;
	GO

	IF OBJECT_ID('dbo.UpdateStudent', 'P') IS NOT NULL
      DROP PROCEDURE dbo.UpdateStudent;
    GO
	CREATE PROCEDURE [dbo].[UpdateStudent]
		 @StudentID INT,
		 @FirstName VARCHAR(50),
		 @LastName VARCHAR(50),
		 @Class VARCHAR(50),
		 @Section VARCHAR(50),
		 @DateOfBirth DATE ,
		 @Contact VARCHAR(20)
	AS
	  BEGIN
	  UPDATE Student_tbl
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        Class = @Class,
        Section = @Section,
        DateOfBirth = @DateOfBirth,
        Contact = @Contact
           WHERE StudentID = @StudentID

	  END;
	   GO
	
	IF OBJECT_ID('dbo.DeleteStudentById', 'P') IS NOT NULL
      DROP PROCEDURE dbo.DeleteStudentById;
    GO
	CREATE PROCEDURE [dbo].[DeleteStudentById]
		@StudentID INT
	AS
	 BEGIN
	  DELETE FROM Student_tbl
     WHERE StudentID = @StudentID;

	  END;
	  GO

    IF OBJECT_ID('dbo.GetStudentById', 'P') IS NOT NULL
      DROP PROCEDURE dbo.GetStudentById;
    GO
	CREATE PROCEDURE [dbo].[GetStudentById]
		@StudentID INT
	AS
	 BEGIN
	 SELECT *
    FROM Student_tbl
    WHERE StudentID = @StudentId;

	  END;
	  GO

	IF OBJECT_ID('dbo.GetAllStudents', 'P') IS NOT NULL
      DROP PROCEDURE dbo.GetAllStudents;
    GO
	CREATE PROCEDURE [dbo].[GetAllStudents]
		
	AS
	 BEGIN
	 SELECT *FROM Student_tbl;
	  END;
	  GO
	  
    IF OBJECT_ID('dbo.UpdateAttendance', 'P') IS NOT NULL
      DROP PROCEDURE dbo.UpdateAttendent;
    GO
	CREATE PROCEDURE [dbo].[UpdateAttendent]
		@StudentID INT,
		@AttendanceDate DATE,
		@StatusAttendance VARCHAR(30),
		@Remarks VARCHAR(100)
	AS
	 BEGIN
	UPDATE Attendent_tbl
    SET StatusAttendance = @StatusAttendance
    WHERE StudentID = @StudentID
    AND AttendanceDate = @AttendanceDate;
	  END;
	  GO
	
	IF OBJECT_ID('dbo.DeleteAttendance', 'P') IS NOT NULL
      DROP PROCEDURE dbo.DeleteAttendance;
    GO
	CREATE PROCEDURE [dbo].[DeleteAttendance]
		@StudentID INT,
		@AttendanceDate DATE
	AS
	 BEGIN
			 DELETE FROM Attendance_tbl
				 WHERE StudentID = @StudentID
				 AND AttendanceDate = @AttendanceDate
	  END;
	  GO

	IF OBJECT_ID('dbo.GetAttendanceByStudentID', 'P') IS NOT NULL
	  DROP PROCEDURE dbo.GetAttendanceByStudentID;
    GO
	CREATE PROCEDURE [dbo].[GetAttendanceByStudentID]
		@StudentID INT
	AS
	 BEGIN	
		SELECT *
		FROM Attendance_tbl
		WHERE StudentID = @StudentID;
	  END;
	  GO

	IF OBJECT_ID('dbo.GetAttendanceSummaryBYID', 'P') IS NOT NULL
		DROP PROCEDURE dbo.GetAttendanceSummaryBYID;
    GO
	CREATE PROCEDURE [dbo].[GetAttendanceSummaryBYID]
		@StudentID INT
	AS
	 BEGIN	
	 SELECT 
        StudentID,
        COUNT(*) AS TotalRecords,
        SUM(CASE WHEN StatusAttendance  = 'Present' THEN 1 ELSE 0 END) AS TotalPresent,
        SUM(CASE WHEN StatusAttendance = 'Absent' THEN 1 ELSE 0 END) AS TotalAbsent,
        (SUM(CASE WHEN StatusAttendance = 'Present' THEN 1 ELSE 0 END) * 100.0 / COUNT(*)) AS AttendanceRate
		FROM Attendence_tbl
			WHERE StudentID = @StudentId
			GROUP BY StudentID;
	  END;
	  GO

	    IF OBJECT_ID('dbo.GetAttendanceSummaryAll', 'P') IS NOT NULL
    DROP PROCEDURE dbo.GetAttendanceSummaryAll;
    GO
	CREATE PROCEDURE [dbo].[GetAttendanceSummaryAll]
	AS
	 BEGIN	
	 SELECT 
        StudentID,
        COUNT(*) AS TotalRecords,
        SUM(CASE WHEN StatusAttendance  = 'Present' THEN 1 ELSE 0 END) AS TotalPresent,
        SUM(CASE WHEN StatusAttendance = 'Absent' THEN 1 ELSE 0 END) AS TotalAbsent,
        (SUM(CASE WHEN StatusAttendance = 'Present' THEN 1 ELSE 0 END) * 100.0 / COUNT(*)) AS AttendanceRate
			FROM Attendance_tbl
			GROUP BY StudentID;
	  END;
	  GO

	IF OBJECT_ID('dbo.GetClassAttendanceReport', 'P') IS NOT NULL
		 DROP PROCEDURE dbo.GetClassAttendanceReport;
    GO
	CREATE PROCEDURE [dbo].[GetClassAttendanceReport]
		@ClassID INT,
		@AttendanceDate DATE
	AS
	 BEGIN	
	 SELECT 
        s.StudentId,
        s.FirstName,
        s.ClassID,
        COALESCE(SUM(CASE WHEN a.StatusAttendance = 'Present' THEN 1 ELSE 0 END), 0) AS TotalPresent,
        COALESCE(SUM(CASE WHEN a.StatusAttendance = 'Absent' THEN 1 ELSE 0 END), 0) AS TotalAbsent,
        COUNT(a.AttendanceDate) AS TotalRecords,
        (COALESCE(SUM(CASE WHEN a.StatusAttendance = 'Present' THEN 1 ELSE 0 END), 0) * 100.0 / NULLIF(COUNT(a.AttendanceDate), 0)) AS AttendanceRate
    FROM Student_tbl s
    LEFT JOIN Attendent_tbl a ON s.StudentId = a.StudentId AND a.AttendanceDate = @AttendanceDate
    WHERE s.ClassID = @ClassID
    GROUP BY s.StudentId, s.FirstName, s.ClassId;
	  END;
	  GO
