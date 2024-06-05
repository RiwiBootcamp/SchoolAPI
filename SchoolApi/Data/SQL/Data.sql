-----## Courses Data ##-----
INSERT INTO Courses (`Name`, `Description`, `Schedule`, `Duration`, `Capacity`, `IdTeacher`) VALUES
('Chemestry', 'Chemestry course for university', '8:00 - 12:00', '3 mounts', 10, 1),
('Mathematics', 'Mathematics course for university', '9:00 - 13:00', '3 mounts', 50, 3),
('Software Engineer', 'Software course for university', '10:00 - 16:00', '12 mounts', 10, 2);

-----## Enrollments Data ##-----
INSERT INTO Enrollments (`Date`, `Status`, `IdStudent`, `IdCourse`) VALUES
('2024-06-04', 'Paid', 2, 3),
('2024-06-05', 'Not Paid', 1, 2),
('2024-06-06', 'Canceled', 1, 1);

-----## Teachers Data ##-----
INSERT INTO Teachers (`FullName`, `Speciality`, `Phone`, `Email`, `YearsExperience`) VALUES
('Josh Amorle', 'Doctor', '+5730065321', 'josh@example.com', 3),
('Karen Lukovic', 'STEMP Specialist', '+5730062349764', 'karen@example.com', 7),
('Tomin Kitory', 'Google Solution Manager', '+5730461322', 'tomin@example.com', 10);

-----## Students Data ##-----
INSERT INTO Students (`FullName`, `BirthDate`, `Address`, `Email`) VALUES
('Carlos Marulanda', '2000-12-31', 'Colombia', 'carlos@example.com'),
('Runtrafan Sail', '1980-01-01', 'India', 'runtrafan@example.com'),
('Minitu Mulan', '2001-07-12', 'China', 'minuti@example.com');