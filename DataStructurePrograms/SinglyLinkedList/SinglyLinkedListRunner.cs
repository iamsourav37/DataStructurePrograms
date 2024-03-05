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

			singlyLinkedList.InsertFirst(24);
			singlyLinkedList.InsertFirst(29);
			singlyLinkedList.InsertFirst(3);
			singlyLinkedList.InsertFirst(98);
			singlyLinkedList.ShowList();
		}
	}
}
