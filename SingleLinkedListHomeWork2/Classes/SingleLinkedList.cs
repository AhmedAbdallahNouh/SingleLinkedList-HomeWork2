using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SingleLinkedListHomeWork2.Classes
{
	public class SingleLinkedList 
	{
		public Node? Head { get; set; }
		public Node? Tail { get; set; }
		public int Length { get; private set; } = 0;
		public SingleLinkedList() { }
		  
		public SingleLinkedList(Node? head = null)
		{
			Head = head;
			Tail = head;
			Tail.next = null;
		}
		public SingleLinkedList(Node? head = null, Node? tail = null)
		{
			Head = head;
			Tail = tail;
		}



		#region Utilities Methods
		private bool IsTail(Node node) => node == Tail;
		private bool IsHead(Node node) => node == Head;
		private void IncreaseLength() => Length++;
		private void DecreaseLength() => Length--;
		public virtual void Print()
		{
			Node? current = Head;
			while (current is not null)
			{
				Console.Write(current.data+ "  ");
				current = current.next;
			}
		}

		public void InsertEnd(int value)
		{
			Node node = new Node(value);
			if (Head is null)
			{
				Head = Tail = node;
				Length++;
				return;
			}
			Tail.next = node;
			Tail = node;
			Length++;

		}
		public void InsertFront(int value)
		{
			Node node = new Node(value);
			if (node is null)
				return;

			if (Head is null)
			{
				Head = Tail = node;
				Length++;
				return;
			}

			node.next = Head;
			Head = node;
			Length++;
		}

		public void InsertBefor(Node nodeToInsert, Node previous, Node current)
		{
			if (nodeToInsert is null || previous is null || current is null)
			{
				Console.WriteLine("Nodes Parameters Shouldnt Be Null");
				return;
			}
			previous.next = nodeToInsert;
			nodeToInsert.next = current;
			IncreaseLength();
		}

		public void DeleteAndLinkNodes(Node nodeToDelte,Node nodeToLink)
		{
			if(nodeToDelte is null || nodeToLink is null)
			{
                Console.WriteLine("Two Nodes Should not be nulls");
				return;
            }

			bool isTail = IsTail(nodeToDelte);
			bool isHead = IsHead(nodeToDelte);
			if (isTail)
			{
				nodeToLink.next = nodeToDelte.next;
				nodeToDelte = null!;
				Tail = nodeToLink ;

			}
			if (isHead)
			{
				Head = nodeToLink ;
				nodeToDelte = null;
			}

			nodeToLink.next = nodeToDelte.next;
			nodeToDelte = null;

			DecreaseLength();
		}

		private void SwapNodesData(Node firstNode , Node secondNode)
		{
			int temp = 0;
			temp = firstNode.data;
			firstNode.data = secondNode.data;
			secondNode.data = temp;
		}
		#endregion


		#region problem 1 
		//implemented Delete with key
		public int DeleteNodeWithkey(int value)
		{
			if (Head is null)
				return -1;

			if (Head == Tail  && Head.data == value)
			{
				Head = Tail = null;
				DecreaseLength();
				return 1;
			}

			if (Head.next is not null && Head.data == value)
			{
				DeleteAndLinkNodes(Head, Head.next);
				return 1;
			}

			int counter = 1;
			for(Node? pervious = Head, current = Head.next ; current is not null; current = current.next, pervious = pervious?.next)
			{
				if(current.data == value)
				{
					DeleteAndLinkNodes(current, pervious);
					return ++counter;
				}
				counter++;	
			}

			return -1;
				
		}
		#endregion

		#region problem 2 
		//implemented Swap
		public void SwapPairs()
		{
			
			if (Length == 0)
			{
				Console.WriteLine("Linked List Is Empty");
				return;
			}

			if(Length == 1) 
			{
				Console.WriteLine("Linked List Should Consist Of At Least 2 Nodes");
				return;
			}
			for(Node? current = Head ; current is not null; current = current?.next?.next)
			{
				if(current.next is not null)
				{
					SwapNodesData(current, current.next);

				}
			}

		}
		#endregion
		

		#region problem 3 
		//implemented Reverse
		public void Reverse()
		{
			Tail = Head;
			Node? previous = Head;
			Node? current = Head?.next;

			while (current != null)
			{
				Node? next = current.next;
				current.next = previous;
				previous = current;
				current = next;
			}

			Head = previous;
			Tail.next = null;
	
		}
		#endregion

		#region problem 4 
		//implemented Get nth from back
		public void DeleteEvenPositions()
		{

			if (Length == 0)
			{
				Console.WriteLine("Linked List Is Empty");
				return;
			}

			if (Length == 1)
			{
				Console.WriteLine("Linked List Have Not Even Positions");
				return;
			}

			for (Node? previous = Head, current = Head?.next ; current is not null; previous =current?.next ,current = current?.next?.next)
			{
				if (current is not null)
				{
					DeleteAndLinkNodes(current, previous);
				}
			}

		}
		#endregion
		#region problem 4 
		//implemented Get nth from back
		public void InsertSorted(int value)
		{
			if (Length == 0 || value > Tail.data)
			{
				InsertEnd(value);
				return;
			}
	
			if(value < Head.data)
			{
				InsertFront(value);
				return;
			}
			

			for (Node? previous = null,  current = Head ; current is not null; previous = current, current = current?.next)
			{
				if (value <=  current.data)
				{	
					InsertBefor(new Node(value), previous, current);
					return;
				}
			
			}

		}
		#endregion

		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}
	}
}
