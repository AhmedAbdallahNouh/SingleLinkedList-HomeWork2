using Microsoft.VisualBasic.FileIO;

namespace SingleLinkedListHomeWork2.Classes
{
	public class Node
	{
		public int data { get; set; }
		public Node? next { get; set; }

		public Node(int data)
		{
			this.data = data;
		}


		public static void print(Node head)
		{
			while (head != null)
			{
				Console.WriteLine(head.data);
				head = head.next!;
			}
		}
		public static void print1(Node head)
		{
			for (Node current = head; current is not null; current = current.next)
			{
				Console.WriteLine(current.data);
			}
		}
		public static void printRecursively(Node head)
		{
			if (head is null)
			{
				return;
			}
			Console.WriteLine(head.data);
			printRecursively(head.next);
		}
		public static Node? Find(int value, Node? head)
		{
			while (head != null)
			{
				if (value == head.data)
					return head;
				head = head.next;
			}
			return null;
		}
		public static int Delete(ref Node node)
		{
			if(node is null)
				return -1;

			node = null;
			return 1;
		}
		~Node()
		{
            Console.WriteLine($"Node With Value{data} Was Deleted");
        }

	}
}