using AbdulazeezKolawoleC_AssignmentTwo;
using System;


namespace StackProject
{
    class Program
    {
        static void Main(string[] arg)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}