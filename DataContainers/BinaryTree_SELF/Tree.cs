using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_SELF
{
	internal class Tree
	{
		public class Element
		{
			public int Data { get; set; }
			public Element pLeft { get; set; }
			public Element pRight { get; set; }
			public Element(int data, Element pLeft = null, Element pRight = null)
			{
				Data = data;
				this.pLeft = pLeft;
				this.pRight = pRight;
			}


		}
		public Element Root { get; set; }

		public Tree()
		{
			Root = null;
		}
		public void Insert(int Data)
		{
			Insert(Data, Root);
		}

		private void Insert(int Data, Element Root)
		{
			if (this.Root == null) this.Root = new Element(Data);
			if (Root == null) return;
			if (Data < Root.Data)
			{
				if (Root.pLeft == null) { Root.pLeft = new Element(Data); }
				else Insert(Data, Root.pLeft);


			}
			else
			{
				if (Root.pRight == null) Root.pRight = new Element(Data);
				else Insert(Data, Root.pRight);
			}


		}
		public int MinValue() {  return MinValue(Root); }
		int MinValue(Element Root)
		{
			if (Root == null) throw new Exception("Tree is empty");
			else return Root.pLeft == null  ? Root.Data : MinValue(Root.pLeft);
		}
		public int MaxValue() {  return MaxValue(Root); }
		int MaxValue(Element Root)
		{
			if(Root == null) throw new Exception("Tree is empty");
			return Root.pRight==null?Root.Data : MaxValue(Root.pRight);
		}
		public void Print()
		{
			Print(Root);
		}
		void Print(Element Root)
		{
			if (Root == null) return;
			Print(Root.pLeft);
			Console.Write(Root.Data + "\t");
			Print(Root.pRight);
		}

	}
}
