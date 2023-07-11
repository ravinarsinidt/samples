using System;

namespace PropertiesEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(200);
            student.XNumber = 1;
            Console.WriteLine(student.XNumber);

        }
    }
}
