using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = CreateStudents();
            List<Student> studentsWithS = GetStudentsNameStartWithLetterS(students);
            Console.WriteLine("Students with Letter Starts with 'S'");
            PrintStudentData(studentsWithS);
            List<Student> topStudents = GetStudentsWithTopMarks(students);
            Console.WriteLine("Top Students");
            PrintStudentData(topStudents);
        }
        private static List<Student> GetStudentsWithTopMarks(List<Student> students)
        {
            List<Student> topStudents = new List<Student>();
            int top = -1;

            foreach (var student in students)
            {
                if(student.Marks > top)
                {
                    top = student.Marks;
                }
            }

            foreach (var student in students)
            {
                if (student.Marks == top)
                {
                    topStudents.Add(student);
                }
            }

            return topStudents;
        }

        private static void PrintStudentData(List<Student> studentsWithS)
        {
            foreach (Student student in studentsWithS)
            {
                Console.WriteLine($"Name : {student.Name}, Marks : {student.Marks}, Branch : {student.Branch}");
            }
        }

        private static List<Student> GetStudentsNameStartWithLetterS(List<Student> students)
        {
            List<Student> studentListWithS = new List<Student>();

            foreach (Student student in students)
            {
                if (student.Name.StartsWith("S"))
                {
                    studentListWithS.Add(student);
                }
            }

            return studentListWithS;
        }

        private static Student CreateStudent(string name, int marks, string branch)
        {
            Student student = new Student();
            student.Name = name;
            student.Marks = marks;
            student.Branch = branch;

            return student;
        }

        private static List<Student> CreateStudents()
        {
            List<Student> students = new List<Student>();

            Student s = CreateStudent("Ravi", 100, "CSE");
            students.Add(s);
            s = CreateStudent("Raheem", 100, "CSE");
            students.Add(s);
            s = CreateStudent("Sam", 80, "IT");
            students.Add(s);
            s = CreateStudent("Jam", 100, "CSE");
            students.Add(s);
            s = CreateStudent("Radha", 65, "ECE");
            students.Add(s);
            s = CreateStudent("Krishna", 75, "IT");
            students.Add(s);
            s = CreateStudent("Ram", 99, "ECE");
            students.Add(s);
            s = CreateStudent("Sita", 64, "ECE");
            students.Add(s);

            return students;
        }
    }
}
