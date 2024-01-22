//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace Accademy_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if WRITE_TO_FILE
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
			Print(group);
			Save(group, "groupfile.txt");
#endif
			Human[] group = Load("groupfile.txt");
			Print(group);


		}
		public static void Print(Human[] group)
		{
			foreach (Human h in group)
			{
				Console.WriteLine
					($"{h.GetType().ToString().Split('.').Last()}:{h}");
			}
		}
		public static void Save(Human[] group, string filename)
		{
			//открытие и запись обьектов  в  файл group.txt по указанному пути
			Directory.SetCurrentDirectory("..\\..");
			StreamWriter sw = new StreamWriter(filename);
			foreach (Human h in group)
			{
				sw.WriteLine
					($"{h.GetType().ToString().Split('.').Last()}:{h};");
			}
			sw.Close();

			System.Diagnostics.Process.Start("notepad", $"{Directory.GetCurrentDirectory()}\\{filename}");

			

		}

		public static Human[] Load(string filename)
		{
			Directory.SetCurrentDirectory("..\\..");
			Console.WriteLine(Directory.GetCurrentDirectory());
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				string[] values = buffer.Split(':', ',', ';');
				group.Add(HumanFactory(values[0]));
				if (group.Last() == null) group.RemoveAt(group.Count - 1);
				else group.Last().Init(values);
			}
			sr.Close();
			return group.ToArray();
		}
		public static Human HumanFactory(string type)
		{
			
			if (type == "Student") return new Student("", "", 0, "", "", 0, 0);
			if (type == "Graduate") return new Graduate("", "", 0, "", "", 0, 0, "");
			if (type == "Teacher") return new Teacher("", "", 0, "", 0);
			return null;
			

		}

	}
}
