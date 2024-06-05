-- Active: 1717616935486@@127.0.0.1@3306@bc4mqniikcg2ruxesufj
-----## Courses Table ##-----
/*
  ## Schedule example: 8:00 - 12:00

  ## Capacity: How many students can roll
*/

CREATE TABLE Courses (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(125),
  Description TEXT,
  Schedule VARCHAR(125),
  Duration VARCHAR(125),
  Capacity INT,
  IdTeacher INT,
  Foreign Key (IdTeacher) REFERENCES Teachers(Id)
);

-----## Enrollments Table ##-----
CREATE TABLE Enrollments (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Date DATE,
  Status ENUM("Paid", "Not Paid", "Canceled"),
  IdStudent INT,
  IdCourse INT,
  Foreign Key (IdStudent) REFERENCES Students(Id),
  Foreign Key (IdCourse) REFERENCES Courses(Id)
);

-----## Teachers Table ##-----
CREATE TABLE Teachers (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  FullName VARCHAR(125),
  Speciality VARCHAR(125),
  Phone VARCHAR(25),
  Email VARCHAR(125) UNIQUE,
  YearsExperience INT(20)
);

-----## Students Table ##-----
CREATE TABLE Students (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  FullName VARCHAR(125),
  BirthDate DATE,
  Address VARCHAR(125),
  Email VARCHAR(125) UNIQUE
);