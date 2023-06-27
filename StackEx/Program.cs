using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace StackEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AudreeStack stack = new AudreeStack();
                stack.Push(100);
                stack.Push(-1);
                stack.Push(-1);
                stack.Push(400);
                stack.Push(500);
                stack.Push(600);
                Console.WriteLine("Count : " + stack.GetCount());
                Console.WriteLine("6th Pop: " + stack.Pop());
                Console.WriteLine("7th Pop: " + stack.Pop());
                Console.WriteLine("After 2 Pops => Count : " + stack.GetCount());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
