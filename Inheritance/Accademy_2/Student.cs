using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy_2
{
	class Student : Human
	{
		/*_______________Поля_Класса__________________*/
		public string Speciality { get; set; }
		public string Group { get; set; }

		public double Rating { get; set; }

		public double Attendance { get; set; }
		/*________________Конструкторы________________*/
		public Student
			(
			string lastName, string firstName, int age,
			string speciality, string group,double rating,double attendance
			):base(lastName,firstName,age)//ключевое слово base необходимо для передачи аргументо
										  //из родительского класса
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine("StudConstructor:\t" + GetHashCode());
		}
		/*________________Деструкторы________________*/
		~Student() { Console.WriteLine("StudDestructor:\t" + GetHashCode()); }
		/*________________Методы_____________________*/
		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality},{Group},{Rating},{Attendance}");
		}
		public override string ToString()//ovveride необходим для переопределения функции
		{
			return base.ToString() + $"{Speciality},{Group},{Rating},{Attendance}";
		}
	}
}
