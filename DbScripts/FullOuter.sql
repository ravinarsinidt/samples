SELECT S.Id, S.Name AS StudentName , SC.CourseId, C.Name AS CourseName
FROM dbo.Student AS S
JOIN dbo.StudentCourse AS SC ON (S.Id = SC.StudentId)
JOIN dbo.Course AS C ON (C.Id = SC.CourseId)

SELECT S.Id, S.Name AS StudentName , SC.CourseId, C.Name AS CourseName
FROM dbo.Student AS S
FULL JOIN dbo.StudentCourse AS SC ON (S.Id = SC.StudentId)
FULL JOIN dbo.Course AS C ON (C.Id = SC.CourseId)

SELECT S.*, SC.*
FROM dbo.Student AS S
CROSS JOIN dbo.Course AS SC