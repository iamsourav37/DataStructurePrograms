using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.SinglyLinkedList
{
	internal class SinglyLinkedList : ISinglyLinkedList
	{
		Node? _head;
		public SinglyLinkedList()
		{
			_head = null;
		}
		public int CountNodes()
		{
			throw new NotImplementedException();
		}

		public void InsertFirst(int data)
		{
			_head = new Node() { Data = data, Next = _head };
			Console.WriteLine($"InsertFirst(), {data} is Inserted in the First Position.");
		}

		public void InsertLast(int data)
		{
			throw new NotImplementedException();
		}

		public void RemoveFirst()
		{
			throw new NotImplementedException();
		}

		public void RemoveLast()
		{
			throw new NotImplementedException();
		}

		public void ShowList()
		{

			if (_head is null)
			{
				Console.WriteLine("List is empty !!!");
				return;
			}

			Console.WriteLine("List elements are: ");
			var temp = _head;

			StringBuilder listElements = new();

			while (temp is not null)
			{
				listElements.Append($"{temp.Data}->");
				temp = temp.Next;
			}
			listElements.Append("NULL");
			Console.WriteLine(listElements);
			Console.WriteLine();
		}
	}
}
