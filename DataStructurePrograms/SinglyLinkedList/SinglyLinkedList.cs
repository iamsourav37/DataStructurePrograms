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
			if (_head is null) return 0;

			var temp = _head;
			int count = 0;
			while (temp != null)
			{
				count++;
				temp = temp.Next;
			}
			return count;
		}

		public void InsertFirst(int data)
		{
			_head = new Node() { Data = data, Next = _head };
			Console.WriteLine($"InsertFirst(), {data} is Inserted in the First Position.");
		}

		public void InsertLast(int data)
		{
			if (_head is null)
			{
				_head = new Node() { Data = data, Next = _head };
			}

			Node temp = _head;

			while (temp.Next != null)
			{
				temp = temp.Next;
			}

			temp.Next = new Node() { Data = data, Next = null };
			Console.WriteLine($"InsertLast(), {data} is Inserted in the Last Position.");

		}

		public void RemoveFirst()
		{

			if (_head is null)
			{
				Console.WriteLine("List is empty !!!");
				return;
			}

			var removedData = _head.Data;
			_head = _head.Next;
			Console.WriteLine($"RemoveFirst(), Removed Element: {removedData}");
		}

		public void RemoveLast()
		{
			
			if (_head is null)
			{
				Console.WriteLine("List is empty !!!");
				return;
			}
			else if (_head.Next is null)
			{
                Console.WriteLine($"RemoveLast(), Removed Element: {_head.Data}");
				_head = null;
				return;
            }

			Node temp = _head;
			Node prevNode = null;

			int removedData;

			while (temp.Next != null)
			{
				prevNode = temp;
				temp = temp.Next;
			}

			removedData = temp.Data;
			prevNode.Next = null;
			Console.WriteLine($"RemoveLast(), Removed Element: {removedData}");
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
				listElements.Append($"{temp.Data}-->");
				temp = temp.Next;
			}
			listElements.Append("NULL");
			Console.WriteLine(listElements);
			Console.WriteLine();
		}
	}
}
