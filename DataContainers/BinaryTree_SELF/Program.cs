using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_SELF
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random(0);
			Console.Write("Введите размер дерева: ");
			int n = Convert.ToInt32(Console.ReadLine());
			UniqueTree tree = new UniqueTree();
			for (int i = 0; i < n; i++)
			{
				tree.Insert(random.Next(100));
			}
			tree.Print();

			Console.WriteLine($"\nМинимальное значение:{tree.MinValue()} ");
			Console.WriteLine($"Максимальное значение: {tree.MaxValue()}");
		}
	}
}
