using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
	class Program
	{
		static void Main(string[] args)
		{
			//char key;
			ConsoleKey key;
			do
			{
				#region KeyChar
				/*key = Console.ReadKey(true).KeyChar;
						Console.WriteLine((int)key + "\t" + key);
						switch (key)
						{
							case 'w': Console.WriteLine("Вперед");	break;
							case 's': Console.WriteLine("Назад");	break;
							case 'a': Console.WriteLine("Влево");	break;
							case 'd': Console.WriteLine("Вправо");	break;
							default:  Console.WriteLine("Error");	break;
						}*/
				#endregion

				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:	Console.WriteLine("Вперед");	break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:	Console.WriteLine("Назад");		break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:	Console.WriteLine("Влево");		break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:	Console.WriteLine("Вправо");	break;
					default:			Console.WriteLine("Error");		break;
				}
			} while (key != ConsoleKey.Escape);
		}
	}
}
