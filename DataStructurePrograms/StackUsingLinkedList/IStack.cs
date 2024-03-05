using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.StackUsingLinkedList
{
    internal interface IStack
    {
        void Push(int data);
        int? Pop();
        int? Peek();
        bool IsUnderflow();
        bool IsOverflow();
        int CountNodes();
        void ShowStack();
    }
}
