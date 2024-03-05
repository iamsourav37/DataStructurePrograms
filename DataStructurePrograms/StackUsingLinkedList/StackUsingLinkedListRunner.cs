using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.StackUsingLinkedList
{
    internal class StackUsingLinkedListRunner
    {
        public void Run()
        {
            StackUsingLinkedList stack = new();



            stack.Push(9);
            stack.Push(91);
            stack.Push(17);
            stack.Push(18);
            stack.Push(27);
            stack.Push(37);
            stack.Push(88);


            stack.ShowStack();


            Console.WriteLine($"Poped element is: {stack.Pop()}");
            stack.ShowStack();

            Console.WriteLine($"Total Node Count: {stack.CountNodes()}");


        }
    }
}
