using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.SinglyLinkedList
{
	internal interface ISinglyLinkedList
	{
		void InsertFirst(int data);
		void InsertLast(int data);
		void RemoveFirst();
		void RemoveLast();
		void ShowList();
		int CountNodes();
	}
}
