using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.StackUsingLinkedList
{
    internal class StackUsingLinkedList : IStack
    {
        Node? _head;

        public StackUsingLinkedList()
        {
            _head = null;
        }
        public int CountNodes()
        {
            if (_head == null) return 0;
            var temp = _head;
            int count = 0;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }

        public bool IsOverflow()
        {
            // This method is not required
            throw new NotImplementedException();
        }

        public bool IsUnderflow()
        {
            return _head == null;
        }
        public int? Peek()
        {
            if (IsUnderflow())
            {
                Console.WriteLine("Stack is undeflow !!!");
                return null;
            }
            return _head.Data;
        }

        public int? Pop()
        {
            if (IsUnderflow())
            {
                Console.WriteLine("Stack is undeflow !!!");
                return null;
            }

            int popedElement = _head.Data;
            _head = _head.Next;
            return popedElement;
        }

        public void Push(int data)
        {
            _head = new Node() { Data = data, Next = _head };
        }

        public void ShowStack()
        {
            if (IsUnderflow())
            {
                Console.WriteLine("Stack is undeflow !!!");
                return;
            }

            Console.WriteLine("Stack elements are: ");
            var temp = _head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
