using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
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
            this._size = size;
            this._top = -1;
            this._stackArray = new int[size];
        }

        public bool IsUnderflow()
        {
            return this._top == -1;
        }

        public bool IsOverflow()
        {
            return this._top == this._size - 1;
        }


        public void Pop()
        {
            if (this.IsUnderflow())
            {
                Console.WriteLine("Stack is underflow !!!");
                return;
            }

            int popedElement = this._stackArray[this._top];
            this._top--;
            Console.WriteLine($"Pop element: {popedElement}");

        }

        public void Push(int data)
        {
            if (this.IsOverflow())
            {
                Console.WriteLine("Stack is overflow !!!");
                return;
            }

            this._top++;
            this._stackArray[this._top] = data;
            Console.WriteLine($"{data} is pushed.");
        }

        public int? Peek()
        {
            if (this.IsUnderflow())
            {
                Console.WriteLine("Stack is underflow");
                return null;
            }

            return this._stackArray[this._top];
        }

        public void Show()
        {
            if (this.IsUnderflow())
            {
                Console.WriteLine("Stack is underflow");
            }

            Console.WriteLine("Stack's elements are: ");
            for (int i = this._top; i >= 0; i--)
            {
                Console.WriteLine(this._stackArray[i]);
            }


        }
    }
}
