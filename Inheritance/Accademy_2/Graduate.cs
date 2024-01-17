using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy_2
{
	internal class Graduate : Student
	{
		public string Subject { get; set; }
		public Graduate
		(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string subject
		) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Subject = subject;
            Console.WriteLine("GConstructor" + GetHashCode());
        }
		public Graduate(Student student,string subject):base(student)
		{
			Subject=subject;
            Console.WriteLine("Gconstructor "+ GetHashCode());
        }
		~Graduate() { Console.WriteLine("GDestructor" + GetHashCode()); }
		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Subject}");
		}
		public override string ToString()//ovveride необходим для переопределения функции
		{
			return base.ToString() + $" {Subject}";
		}
	}
}
