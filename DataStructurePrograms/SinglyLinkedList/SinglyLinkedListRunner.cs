using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.SinglyLinkedList
{
	internal class SinglyLinkedListRunner
	{
		public void Run()
		{
			SinglyLinkedList singlyLinkedList = new();


			//singlyLinkedList.ShowList();

			singlyLinkedList.InsertFirst(24);
			singlyLinkedList.InsertLast(29);
			singlyLinkedList.InsertLast(80);
			singlyLinkedList.InsertFirst(21);

			//singlyLinkedList.ShowList();

			singlyLinkedList.RemoveLast();
			singlyLinkedList.RemoveFirst();

			//Console.WriteLine($"Total Node Count: {singlyLinkedList.CountNodes()} ");
            singlyLinkedList.ShowList();
		}
	}
}
