using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.StackUsingArray
{
    internal class StackRunner
    {
        public void Run()
        {
            StackUsingArray stackUsingArray = new(5);


            Console.WriteLine($"Peek element is: {stackUsingArray.Peek()}");
            stackUsingArray.Pop();
            stackUsingArray.Push(8);
            stackUsingArray.Push(24);
            stackUsingArray.Push(29);
            stackUsingArray.Push(3);
            stackUsingArray.Push(98);
            stackUsingArray.Push(98);
            stackUsingArray.Push(98);

            Console.WriteLine($"Peek element is: {stackUsingArray.Peek()}");

            stackUsingArray.Show();
        }
    }
}
