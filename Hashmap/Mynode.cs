using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableandBinaryTree
{
	public class MyMapNode
	{
		string key;
		int value;
		public MyMapNode next;

		public MyMapNode(string key, int value)
		{
			this.key = key;
			this.value = value;
			next = null;
		}

		public string getKey()
		{
			return key;
		}

		public void setKey(string key)
		{
			this.key = key;
		}
		public MyMapNode getNext()
		{
			return next;
		}

		public void setNext(MyMapNode next)
		{
			this.next = (MyMapNode)next;
		}

		public int getValue()
		{
			return this.value;
		}

		public void setValue(int value)
		{
			this.value = value;
		}

		public String toString()
		{
			StringBuilder myMapNodeString = new StringBuilder();
			myMapNodeString.Append("MyMapNode{" + "K=").Append(key)
			.Append(" V= ").Append(value).Append('}');
			if (next != null)
			{
				myMapNodeString.Append("->").Append(next);
			}
			return myMapNodeString.ToString();
		}

	}
}
