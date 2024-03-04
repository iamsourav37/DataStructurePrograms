using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.StackUsingArray
{

    public interface IStack
    {
        void Pop();
        void Push(int data);
        int? Peek();
        bool IsUnderflow();
        bool IsOverflow();
        void Show();
    }

    public class StackUsingArray : IStack
    {
        int _size;
        int _top;
        int[] _stackArray;

        public StackUsingArray(int size)
        {
            _size = size;
            _top = -1;
            _stackArray = new int[size];
        }

        public bool IsUnderflow()
        {
            return _top == -1;
        }

        public bool IsOverflow()
        {
            return _top == _size - 1;
        }


        public void Pop()
        {
            if (IsUnderflow())
            {
                Console.WriteLine("Stack is underflow !!!");
                return;
            }

            int popedElement = _stackArray[_top];
            _top--;
            Console.WriteLine($"Pop element: {popedElement}");

        }

        public void Push(int data)
        {
            if (IsOverflow())
            {
                Console.WriteLine("Stack is overflow !!!");
                return;
            }

            _top++;
            _stackArray[_top] = data;
            Console.WriteLine($"{data} is pushed.");
        }

        public int? Peek()
        {
            if (IsUnderflow())
            {
                Console.WriteLine("Stack is underflow");
                return null;
            }

            return _stackArray[_top];
        }

        public void Show()
        {
            if (IsUnderflow())
            {
                Console.WriteLine("Stack is underflow");
            }

            Console.WriteLine("Stack's elements are: ");
            for (int i = _top; i >= 0; i--)
            {
                Console.WriteLine(_stackArray[i]);
            }


        }
    }
}
