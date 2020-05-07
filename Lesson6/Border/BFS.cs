using System.Collections;
using System.Collections.Generic;
using System;

public class BFS
{
	private Queue<Node> q= new Queue<Node>();
	public String path = "";
	public BFS(Node root)
	{
		root.isVisited = true;
		q.Enqueue(root);
	}

	public Node find(int search)
	{
		while (q.Count != 0)
		{
			Node temp = q.Dequeue();
			if (temp.value == search)
			{
				
				Node p = temp;
				path = p.value + path;
				p = p.parent;
				while (p != null)
				{
					path = p.value + " --> " + path;
					p = p.parent;
				}
				return temp;
			}
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
	public Node parent;
	public List<Node> vec = new List<Node>();
	public Node(int other)
	{
		value = other;
		parent = null;
	}
	public void add(Node other)
	{
		vec.Add(other);
		other.parent = this;
	}

}





class Main1
{
	static void Main(string[] args)
	{
		Node n1 = new Node(1);
		Node n2 = new Node(2);
		Node n3 = new Node(3);
		Node n4 = new Node(4);
		Node n5 = new Node(5);
		Node n6 = new Node(6);
		Node n7 = new Node(7);
		n4.add(n3);
		n2.add(n1);
		n1.add(n2);
		n1.add(n3);
		n2.add(n4);
		n5.add(n1);
		n4.add(n6);
		
		BFS b1 = new BFS(n5);
		Node temp = b1.find(6);
		if (temp == null) Console.WriteLine("didnt find");
		else
		{
			Console.WriteLine("the node's value is " + temp.value);
			Console.WriteLine(b1.path);
		}

	}
}