using System;
using System.Collections.Generic;

namespace StudentMgmt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List Students
            List<Student> studentList = SelectEx.GetStudents();
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Name : {student.Name}");
                Console.WriteLine($"Id : {student.Id}");
                Console.WriteLine($"Dummy Id : {student.DummyId}");
            }

            // Add Student
            Student newStudent =  new Student();
            newStudent.Name = "Vasu";
            newStudent.DummyId = 9898;

            int result = InsertEx.Insert( newStudent );
            if(result > 0)
            {
                Console.WriteLine("Student Inserted successfully!");
            }
            else
            {
                Console.WriteLine("Student Insertion failed!");
            }

            // Add Student
            newStudent = new Student();
            newStudent.Name = "Tendulkar";
            newStudent.DummyId = 9999;

            result = InsertEx.Insert(newStudent);
            if (result > 0)
            {
                Console.WriteLine("Student Inserted successfully!");
            }
            else
            {
                Console.WriteLine("Student Insertion failed!");
            }
            // List Students
            studentList = SelectEx.GetStudents();
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Name : {student.Name}");
                Console.WriteLine($"Id : {student.Id}");
                Console.WriteLine($"Dummy Id : {student.DummyId}");
            }
        }
    }
}
