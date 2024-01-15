using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Accademy_2
{
	class Teacher : Human
	{
		public string Speciality { get; set; }
		public int Expirience { get; set; }

		public Teacher
			(
			string lastName, string firstName, int age,
				string speciality, int expirience
			) :base(lastName, firstName, age)
		{
			Speciality = speciality;
			Expirience = expirience;
            Console.WriteLine("TeachConstructor:\t"+GetHashCode());
        }
		~Teacher() { Console.WriteLine("TeachDestructor:\t" + GetHashCode()); }

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality},{Expirience} лет");
		}
		public override string ToString()//ovveride необходим для переопределения функции
		{
			return base.ToString() + $"{Speciality},{Expirience}  лет";
		}
	}
}
