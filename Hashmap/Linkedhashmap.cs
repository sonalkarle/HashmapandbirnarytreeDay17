using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableandBinaryTree
{
	public class MyLinkedHashMap
	{
		MyMapNode head;
		public int numBuckets;
		List<MyLinkedList> myBucketArray;

		public MyLinkedHashMap()
		{
			this.numBuckets = 10;
			this.myBucketArray = new List<MyLinkedList>(numBuckets);
			// create empty Linked List
			for (int i = 0; i < numBuckets; i++)
			{
				this.myBucketArray.Add(null);
			}
		}

		//This implements hash function to find index for a key
		private int getBucketIndex(string key)
		{

			int hashCode = Math.Abs(key.GetHashCode());
			int index = hashCode % numBuckets;
			Console.WriteLine("Key" + key + " hashcode" + hashCode + " index " + index);
			return index;


		}

		public int get(string key)
		{
			int index = this.getBucketIndex(key);
			MyLinkedList myLinkedList = this.myBucketArray[index];
			if (myLinkedList == null) return 0;
			MyMapNode myMapNode = (MyMapNode)myLinkedList.search(key);
			return (myMapNode == null) ? 0 : myMapNode.getValue();
		}

		public void add(string key, int value)
		{
			int index = this.getBucketIndex(key);
			MyLinkedList myLinkedList = this.myBucketArray[index];
			if (myLinkedList == null)
			{
				myLinkedList = new MyLinkedList();
				this.myBucketArray[index] = myLinkedList;
			}
			MyMapNode myMapNode = (MyMapNode)myLinkedList.search(key);
			if (myMapNode == null)
			{
				myMapNode = new MyMapNode(key, value);
				myLinkedList.append(myMapNode);
			}
			else
			{
				myMapNode.setValue(value);
			}
		}

		public void remove(string key)
		{
			int index = this.getBucketIndex(key);
			MyLinkedList myLinkedList = this.myBucketArray[index];
			MyMapNode myMapNode = (MyMapNode)myLinkedList.search(key);
			myLinkedList.delete();

		}

		public String toString()
		{
			return "MyLinked Hash Map{" + myBucketArray + '}';
		}

	}
}
