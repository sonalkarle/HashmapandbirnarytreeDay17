using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableandBinaryTree
{
	class MyLinkedList
	{
		public MyMapNode head;
		public MyMapNode tail;

		public MyLinkedList()
		{
			this.head = null;
			this.tail = null;
		}

		public void add(MyMapNode newNode)
		{
			if (this.tail == null)
			{
				this.tail = newNode;
			}

			if (this.head == null)
			{
				this.head = newNode;
			}
			else
			{
				MyMapNode tempNode = this.head;
				this.head = newNode;
				this.head.setNext(tempNode);
			}


		}

		public void append(MyMapNode newNode)
		{
			if (this.head == null)
			{
				this.head = newNode;
			}
			if (this.tail == null)
			{
				this.tail = newNode;
			}
			else
			{
				MyMapNode tempNode = this.tail;
				this.tail = newNode;
				tempNode.setNext(newNode);
			}

		}

		public void insert(MyMapNode myNode, MyMapNode newNode)
		{
			this.head.setNext(myNode);
			myNode.setNext(newNode);


		}

		public MyMapNode search(string key)
		{
			MyMapNode tempNode = head;
			while (tempNode != null && tempNode.getNext() != null)
			{
				if (tempNode.getKey().Equals(key))
				{
					return tempNode;
				}
				tempNode = tempNode.getNext();
			}
			return null;
		}

		public MyMapNode pop()
		{
			MyMapNode tempNode = this.head;
			this.head = head.getNext();
			return tempNode;
		}

		public MyMapNode popLast()
		{
			MyMapNode tempNode = head;
			while (!tempNode.getNext().Equals(tail))
			{
				tempNode = tempNode.getNext();
			}
			this.tail = tempNode;
			tempNode = tail.getNext();
			tempNode = null;
			return tempNode;
		}

		public void printMyNodes()
		{
			Console.WriteLine("My Nodes: " + head);
		}

		public String toString()
		{
			return "MyLinkedListNodes{" + head + '}';
		}
	}
}