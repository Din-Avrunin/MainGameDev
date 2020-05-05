using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BFS : MonoBehaviour
{
	// Start is called before the first frame update
		private Queue<Node> q;
		public BFS(Node root, int search)
		{
		root.isVisited = true;
		q.Enqueue(root);
		}

		public Node find(int search)
		{
			while (q.Count!=0)
			{
			Node temp = q.Dequeue();
			if (temp.value == search)
				return temp;
			foreach (Node element in temp.vec)
			{
				if (!element.isVisited)
				{
					element.isVisited = true;
					q.Enqueue(element);
				}
			}
			}
		return null;

	}
}
	public class Node
	{
	public Boolean isVisited = false;
		public int value;
		public List<Node> vec = new List<Node>();
		public Node(int other)
		{
			value = other;
		}
		public void add(Node other)
		{
			vec.Add(other);
		}
	}




