//#define WRITE_TO_FILE
#define READ_FROM_FILE
//#define FILE_CREATING
//#define TXT_FILE_OPEN
//#define TEXT_ADD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
	class Program
	{
		static void Main(string[] args)
		{
#if WRITE_TO_FILE
			Console.WriteLine("Hello Files");
			// присваиваем перепменной как узнать адрес директории где файл
			string directory = Directory.GetCurrentDirectory();
			//имя файла
			string filename = "File.txt";
#if FILE_CREATING
			//открытие потока создание файла
			StreamWriter sw = new StreamWriter(filename);
			//Запись данных в файл
			sw.WriteLine("Hello files");
			//закрытие потока
			sw.Close(); 
#endif
#if TEXT_ADD
			//Вывод аддреса файла
			Console.WriteLine(directory);
			//Добавить текст в файл
			using (StreamWriter file = File.AppendText(filename))
			{
				file.WriteLine("Привет!");
			}
#endif

#if TXT_FILE_OPEN
			string cmd = directory + "\\" + filename;        /*открытие файла через */
			System.Diagnostics.Process.Start("notepad", cmd);/*командную строку     */

			Console.ReadKey(); 
#endif
#endif

#if READ_FROM_FILE
			StreamReader sr = new StreamReader("File.txt");
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(buffer);
			}
			sr.Close(); 
#endif
		}
	}
}
