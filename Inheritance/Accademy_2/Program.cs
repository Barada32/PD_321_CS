using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Human human = new Human("Vercetti", "Tommy", 30);
			
			Student student = new Student("Ivan", "Petrov", 25, "Chemestry", "ww2024", 95, 98);
			
			Teacher teacher = new Teacher("Walter", "White", 50, "Chemestry", 20);
			
			Graduate graduate = new Graduate("Hreder", "hank", 40, "Criminal", "OBN", 70, 40, "How to catch Hizenberg");
			
			//через конструктор копирования 
			Student tommi = new Student(human, "Thieth", "Vice", 98, 99);

			
			Graduate tommy_grad = new Graduate(tommi, "How to make money ");
		

			// вывод через массив обьектов

			Human[] group = new Human[]
			{
				student,teacher, tommi, tommy_grad,
				new Graduate("Rozenberg","Ken",30,"Lower","Vice",45,22,"How to get money back")

			};


			foreach (Human h in group)
			{ Console.WriteLine(h); }
		}
	}
}
