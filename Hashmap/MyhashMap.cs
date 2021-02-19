using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableandBinaryTree
{
	public class MyHashMap
	{
		MyLinkedList myLinkedList;

		public MyHashMap()
		{
			this.myLinkedList = new MyLinkedList();
		}

		public int get(string key)
		{
			MyMapNode myMapNode = (MyMapNode)this.myLinkedList.search(key);
			return (myMapNode == null) ? 0 : myMapNode.getValue();
		}

		public void add(string key, int value)
		{
			MyMapNode myMapNode = (MyMapNode)this.myLinkedList.search(key);
			if (myMapNode == null)
			{
				myMapNode = new MyMapNode(key, value);
				this.myLinkedList.append(myMapNode);
			}
			else
			{
				myMapNode.setValue(value);
			}
		}

		public String toString()
		{
			return "MyHashMapNodes{" + myLinkedList + '}';
		}

	}
}